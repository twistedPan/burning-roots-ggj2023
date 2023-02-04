using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    [SerializeField] private Dictionary<string, Player> playersByPlayerId;
    [SerializeField] private List<string> playerIds;
    [SerializeField] private GameObject playerPrefab;
    private PlayerController controls;

    void Awake()
    {
        controls = new PlayerController(); // oooheeey stupid code lalalaaa
        controls.Player.MovePlayer1.performed += ctx => MovePlayer(1 + "" + ctx.control.device.deviceId, ctx.ReadValue<Vector2>());
        controls.Player.MovePlayer2.performed += ctx => MovePlayer(2 + "" + ctx.control.device.deviceId, ctx.ReadValue<Vector2>());
        controls.Player.MovePlayer3.performed += ctx => MovePlayer(3 + "" + ctx.control.device.deviceId, ctx.ReadValue<Vector2>());
        controls.Player.MovePlayer4.performed += ctx => MovePlayer(4 + "" + ctx.control.device.deviceId, ctx.ReadValue<Vector2>());

        controls.Player.MovePlayer1.canceled += _ => MovePlayer(1 + "" + _.control.device.deviceId, Vector2.zero);
        controls.Player.MovePlayer2.canceled += _ => MovePlayer(2 + "" + _.control.device.deviceId, Vector2.zero);
        controls.Player.MovePlayer3.canceled += _ => MovePlayer(3 + "" + _.control.device.deviceId, Vector2.zero);
        controls.Player.MovePlayer4.canceled += _ => MovePlayer(4 + "" + _.control.device.deviceId, Vector2.zero);

        controls.Player.ActionPlayer1.performed += ctx => Action(1 + "" + ctx.control.device.deviceId);
        controls.Player.ActionPlayer2.performed += ctx => Action(2 + "" + ctx.control.device.deviceId);
        controls.Player.ActionPlayer3.performed += ctx => Action(3 + "" + ctx.control.device.deviceId);
        controls.Player.ActionPlayer4.performed += ctx => Action(4 + "" + ctx.control.device.deviceId);

        controls.Player.JoinPlayer1.performed += ctx => RegisterPlayer(1 + "" + ctx.control.device.deviceId, ctx);
        controls.Player.JoinPlayer2.performed += ctx => RegisterPlayer(2 + "" + ctx.control.device.deviceId, ctx);
        controls.Player.JoinPlayer3.performed += ctx => RegisterPlayer(3 + "" + ctx.control.device.deviceId, ctx);
        controls.Player.JoinPlayer4.performed += ctx => RegisterPlayer(4 + "" + ctx.control.device.deviceId, ctx);

        playersByPlayerId = new Dictionary<string, Player>();
        playerIds = new List<string>();
        int playerSlot = 1;
        foreach (var playerDevice in Gamepad.all)
        {
            playerIds.Add((playerSlot++) + "" + playerDevice.deviceId);
            playerIds.Add((playerSlot++) + "" + playerDevice.deviceId);
        }
        //Debug.Log("Gamepad.all.Count: " + Gamepad.all.Count + " Gamepad 1 Id: " + Gamepad.all[0].deviceId + " Gamepad 2 Id: " + Gamepad.all[0].deviceId)
    }

    private void RegisterPlayer(string playerId, InputAction.CallbackContext ctx)
    {
        //if (gameStarted) return;
        int deviceId = ctx.control.device.deviceId;
        Debug.Log("Device Id: " + deviceId + " Player Id: " + playerId + " Button: " + ctx.action.name);

        if (playerId == playerIds[0])
        {
            Debug.Log("PLayer 1");
            AddPlayer(playerId);
        }
        else if (playerId == playerIds[1])
        {
            Debug.Log("PLayer 2");
            AddPlayer(playerId);
        }
        else if (playerId == playerIds[2])
        {
            Debug.Log("PLayer 3");
            AddPlayer(playerId);
        }
        else if (playerId == playerIds[3])
        {
            Debug.Log("PLayer 4");
            AddPlayer(playerId);
        }

        //! device id changes if unity gets restarted (no idea how this behaves in build)
        /*switch (playerId)
        {
            case playerIds[0]:
                Debug.Log("PLayer 1");
                AddPlayer(playerId);
                break;
            case "29":
                Debug.Log("PLayer 2");
                AddPlayer(playerId);
                break;
            case "310":
                Debug.Log("PLayer 3");
                AddPlayer(playerId);
                break;
            case "410":
                Debug.Log("PLayer 4");
                AddPlayer(playerId);
                break;
            default:
                break;
        }*/
    }

    private void AddPlayer(string playerId)
    {
        // return if player has already been added
        if (playersByPlayerId.ContainsKey(playerId))
        {
            RemovePlayer(playerId);
            return;
        }

        GameObject newPlayer = Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
        playersByPlayerId.Add(playerId, newPlayer.GetComponent<Player>());
        Debug.Log("Player " + playerId + " joined");
    }

    private void RemovePlayer(string playerId)
    {
        Player playerToRemove = playersByPlayerId[playerId];
        Debug.Log(playerToRemove.transform.name + " gets removed");
        Destroy(playerToRemove.gameObject);
        playersByPlayerId.Remove(playerId);
    }

    private void MovePlayer(string playerId, Vector2 moveInput)
    {
        if (!playersByPlayerId.ContainsKey(playerId)) return;

        //Debug.Log("Move Player: " + number + ctx.control.device.deviceId);
        playersByPlayerId[playerId].MoveByInput(moveInput);
    }

    private void Action(string playerId)
    {
        if (!playersByPlayerId.ContainsKey(playerId)) return;

        playersByPlayerId[playerId].Action();
    }


    private void OnEnable() => controls.Enable();
    private void OnDisable() => controls.Disable();
}

