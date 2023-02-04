using System;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class PlayerInputManager : MonoBehaviour
{
    [SerializeField] private Dictionary<string, Player> playersByPlayerId;
    [SerializeField] private List<string> playerIds;
    [SerializeField] private GameObject playerPrefab;
    private PlayerController controls;
    [SerializeField] private float spawnRadius = 8f;
    private DynamicCamera cameraScript;

    void Awake()
    {
        cameraScript = FindObjectOfType<DynamicCamera>();
        playersByPlayerId = new Dictionary<string, Player>();
        playerIds = new List<string>();
        int playerSlot = 1;
        foreach (var playerDevice in Gamepad.all)
        {
            playerIds.Add((playerSlot++) + "" + playerDevice.deviceId);
            playerIds.Add((playerSlot++) + "" + playerDevice.deviceId);
        }

        controls = new PlayerController(); // oooheeey stupid code lalalaaa
        //Debug.Log(controls.bindingMask.Value);
        
        /*foreach (var inputScheme in controls.controlSchemes)
        {
            Debug.Log("Scheme: " + inputScheme.name);
        }*/
        controls.Player1.MovePlayer1.performed += ctx => MovePlayer(1 + "" + ctx.control.device.deviceId, ctx.ReadValue<Vector2>(), ctx);
        controls.Player1.MovePlayer2.performed += ctx => MovePlayer(2 + "" + ctx.control.device.deviceId, ctx.ReadValue<Vector2>(), ctx);
        controls.Player2.MovePlayer3.performed += ctx => MovePlayer(3 + "" + ctx.control.device.deviceId, ctx.ReadValue<Vector2>(), ctx);
        controls.Player2.MovePlayer4.performed += ctx => MovePlayer(4 + "" + ctx.control.device.deviceId, ctx.ReadValue<Vector2>(), ctx);

        controls.Player1.MovePlayer1.canceled += _ => StopPlayer(1 + "" + _.control.device.deviceId, Vector2.zero);
        controls.Player1.MovePlayer2.canceled += _ => StopPlayer(2 + "" + _.control.device.deviceId, Vector2.zero);
        controls.Player2.MovePlayer3.canceled += _ => StopPlayer(3 + "" + _.control.device.deviceId, Vector2.zero);
        controls.Player2.MovePlayer4.canceled += _ => StopPlayer(4 + "" + _.control.device.deviceId, Vector2.zero);

        controls.Player1.ActionPlayer1.performed += ctx => Action(1 + "" + ctx.control.device.deviceId);
        controls.Player1.ActionPlayer2.performed += ctx => Action(2 + "" + ctx.control.device.deviceId);
        controls.Player2.ActionPlayer3.performed += ctx => Action(3 + "" + ctx.control.device.deviceId);
        controls.Player2.ActionPlayer4.performed += ctx => Action(4 + "" + ctx.control.device.deviceId);

        controls.Player1.JoinPlayer1.performed += ctx => RegisterPlayer(1 + "" + ctx.control.device.deviceId, ctx);
        controls.Player1.JoinPlayer2.performed += ctx => RegisterPlayer(2 + "" + ctx.control.device.deviceId, ctx);
        controls.Player2.JoinPlayer3.performed += ctx => RegisterPlayer(3 + "" + ctx.control.device.deviceId, ctx);
        controls.Player2.JoinPlayer4.performed += ctx => RegisterPlayer(4 + "" + ctx.control.device.deviceId, ctx);

        
        //Debug.Log("Gamepad.all.Count: " + Gamepad.all.Count + " Gamepad 1 Id: " + Gamepad.all[0].deviceId + " Gamepad 2 Id: " + Gamepad.all[0].deviceId)
    }

    private void RegisterPlayer(string playerId, InputAction.CallbackContext ctx)
    {
        //if (gameStarted) return;
        int deviceId = ctx.control.device.deviceId;
        //Debug.Log("Register Player: Device Id: " + deviceId + " Player Id: " + playerId + " Button: " + ctx.action.name);

        // switch not possible because C# v7
        if (playerId == playerIds[0])
        {
            AddPlayer(playerId);
        }
        else if (playerId == playerIds[1])
        {
            AddPlayer(playerId);
        }
        else if (playerId == playerIds[2])
        {
            AddPlayer(playerId);
        }
        else if (playerId == playerIds[3])
        {
            AddPlayer(playerId);
        }

    }

    private void AddPlayer(string playerId)
    {
        // return if player has already been added
        if (playersByPlayerId.ContainsKey(playerId))
        {
            RemovePlayer(playerId);
            return;
        }

        Vector2 spawnPosition = Random.insideUnitCircle * spawnRadius;
        Vector3 spawnPositionXZ = new Vector3(spawnPosition.x, 0 , spawnPosition.y);
        GameObject newPlayer = Instantiate(playerPrefab, spawnPositionXZ, Quaternion.identity);
        Player playerScript = newPlayer.GetComponent<Player>();
        playerScript.PlayerId = playerId;
        playersByPlayerId.Add(playerId, playerScript);

        cameraScript.AddPlayerToCamera(playerId, newPlayer.transform);
        Debug.Log("Player " + playerId + " joined");
    }

    private void RemovePlayer(string playerId)
    {
        Player playerToRemove = playersByPlayerId[playerId];
        Debug.Log(playerToRemove.transform.name + " gets removed");
        cameraScript.RemovePlayerFromCamera(playerId);
        Destroy(playerToRemove.gameObject);
        playersByPlayerId.Remove(playerId);
    }

    private void MovePlayer(string playerId, Vector2 moveInput, InputAction.CallbackContext ctx)
    {
        Debug.Log("Try to move Player " + playerId + " Action by " + ctx.control);
        if (!playersByPlayerId.ContainsKey(playerId)) return;

        Debug.Log(" -> Moved Player: " + playerId);
        playersByPlayerId[playerId].SetPlayerMoveInput(moveInput);
    }

    private void StopPlayer(string playerId, Vector2 moveInput)
    {
        //Debug.Log("Try to stop Player " + playerId);
        if (!playersByPlayerId.ContainsKey(playerId)) return;

        //Debug.Log(" -> stopped Player: " + playerId);
        playersByPlayerId[playerId].SetPlayerMoveInput(moveInput);
    }

    private void Action(string playerId)
    {
        if (!playersByPlayerId.ContainsKey(playerId)) return;

        playersByPlayerId[playerId].Action();
    }


    private void OnEnable() => controls.Enable();
    private void OnDisable() => controls.Disable();
}

