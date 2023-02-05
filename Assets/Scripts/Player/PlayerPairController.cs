using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;
using Random = UnityEngine.Random;

public class PlayerPairController : MonoBehaviour
{
    [SerializeField] private GameValues gameValues;
    [SerializeField] private Player[] managedPlayers;
    [SerializeField] private GameObject playerPrefab;
    private DynamicCamera cameraScript;
    private PlayerManager playerManager;

    private void Awake()
    {
        managedPlayers = new Player[2];
        cameraScript = FindObjectOfType<DynamicCamera>();
        playerManager = FindObjectOfType<PlayerManager>();
    }

    public void OnMovePlayer1(InputValue value)
    {
        if (managedPlayers[0] == null) return;
        managedPlayers[0].SetPlayerMoveInput(value.Get<Vector2>());
    }

    public void OnMovePlayer2(InputValue value)
    {
        if (managedPlayers[1] == null) return;
        managedPlayers[1].SetPlayerMoveInput(value.Get<Vector2>());
    }

    public void OnStopPlayer1()
    {
        if (managedPlayers[0] == null) return;
        managedPlayers[0].SetPlayerMoveInput(Vector2.zero);
    }

    public void OnStopPlayer2()
    {
        if (managedPlayers[1] == null) return;
        managedPlayers[1].SetPlayerMoveInput(Vector2.zero);
    }

    public void OnActionPlayer1()
    {
        if (managedPlayers[0] == null) return;
        managedPlayers[0].Action();
    }

    public void OnActionPlayer2()
    {
        if (managedPlayers[1] == null) return;
        managedPlayers[1].Action();
    }

    public void OnJoinPlayer1()
    {
        if (managedPlayers[0] != null)
        {
            RemovePlayer(managedPlayers[0]);
            managedPlayers[0] = null;
            return;
        }
        //Debug.Log("Player 1 joined!");
        Vector3 spawnPosition = GetSpawnPosition();
        GameObject newPlayer = Instantiate(playerPrefab, spawnPosition, Quaternion.identity);

        string playerId = newPlayer.GetInstanceID() + "-" + (int)(Random.value * 5);
        managedPlayers[0] = newPlayer.GetComponent<Player>();
        managedPlayers[0].PlayerId = playerId;
        cameraScript.AddPlayerToCamera(playerId + (int)(Random.value*5), newPlayer.transform);
    }

    public void OnJoinPlayer2()
    {
        if (managedPlayers[1] != null)
        {
            RemovePlayer(managedPlayers[1]);
            managedPlayers[1] = null;
            return;
        }
        //Debug.Log("Player 2 joined!");
        Vector3 spawnPosition = GetSpawnPosition();
        GameObject newPlayer = Instantiate(playerPrefab, spawnPosition, Quaternion.identity);

        string playerId = newPlayer.GetInstanceID() + "-" + (int)(Random.value * 5);
        managedPlayers[1] = newPlayer.GetComponent<Player>();
        managedPlayers[1].PlayerId = playerId;
        cameraScript.AddPlayerToCamera(playerId + (int)(Random.value * 5), newPlayer.transform);
    }

    private void RemovePlayer(Player player)
    {
        cameraScript.RemovePlayerFromCamera(player.PlayerId);
        Destroy(player.gameObject);
    }

    private Vector3 GetSpawnPosition()
    {
        int index = Random.Range(0, playerManager.PossibleSpawnPoints.Length + 1);
        Vector3 randomSpawnPosition = playerManager.PossibleSpawnPoints[index].position;
        Vector3 spawnPositionXZ = new Vector3(
            randomSpawnPosition.x + (Random.Range(-1,1) * gameValues.PlayerSpawnPosDeviation), 
            .5f, 
            randomSpawnPosition.z + (Random.Range(-1, 1) * gameValues.PlayerSpawnPosDeviation));

        Debug.Log("Player spawned at " + index +" got " + randomSpawnPosition + " is " + spawnPositionXZ);
        return spawnPositionXZ;
    }
}
