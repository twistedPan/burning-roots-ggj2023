using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;
using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;

public class PlayerPairController : MonoBehaviour
{
    [SerializeField] private GameValues gameValues;
    [SerializeField] private Player[] managedPlayers;
    [SerializeField] private GameObject playerPrefab;
    private DynamicCamera cameraScript;
    private PlayerManager playerManager;
    private Stopwatch swPlayer1;
    private Stopwatch swPlayer2;

    private void Awake()
    {
        managedPlayers = new Player[2];
        cameraScript = FindObjectOfType<DynamicCamera>();
        playerManager = FindObjectOfType<PlayerManager>();
        swPlayer1 = new Stopwatch();
        swPlayer2 = new Stopwatch();
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

    public void OnJoinPlayer1(InputValue value)
    {
        JoinPlayer(value.isPressed, swPlayer1, 0);
    }

    public void OnJoinPlayer2(InputValue value)
    {
        JoinPlayer(value.isPressed, swPlayer2, 1);
    }

    private void JoinPlayer(bool isPressed, Stopwatch sw, int index)
    {
        if (isPressed == true)
        {
            sw.Start();
        }

        if (managedPlayers[index] == null)
        {
            Vector3 spawnPosition = GetSpawnPosition();
            GameObject newPlayer = Instantiate(playerPrefab, spawnPosition, Quaternion.identity);

            string playerId = newPlayer.GetInstanceID() + "-" + (int)(Random.value * 5);
            
            managedPlayers[index] = newPlayer.GetComponent<Player>();
            managedPlayers[index].PlayerId = playerId;
            managedPlayers[index].SetMaterial(playerManager.GetMaterialForPlayer());

            cameraScript.AddPlayerToCamera(playerId, newPlayer.transform);
            // Debug.Log("- Player " + (index + 1) + " joined! - Id " + playerId);
        }
        else
        {
            if (sw.Elapsed.TotalMilliseconds >= 500f)
            {
                RemovePlayer(managedPlayers[index]);
                managedPlayers[index] = null;
            }
        }

        if (isPressed == false)
        {
            sw.Stop();
            sw.Reset();
        }
    }

    private void RemovePlayer(Player player)
    {
        cameraScript.RemovePlayerFromCamera(player.PlayerId);
        Destroy(player.gameObject);
    }

    private Vector3 GetSpawnPosition()
    {
        int index = Random.Range(0, playerManager.PossibleSpawnPoints.Length);
        Vector3 randomSpawnPosition = playerManager.PossibleSpawnPoints[index].position;
        Vector3 spawnPositionXZ = new Vector3(
            randomSpawnPosition.x + (Random.Range(-1, 1) * gameValues.PlayerSpawnPosDeviation),
            .5f,
            randomSpawnPosition.z + (Random.Range(-1, 1) * gameValues.PlayerSpawnPosDeviation));

        return spawnPositionXZ;
    }
}
