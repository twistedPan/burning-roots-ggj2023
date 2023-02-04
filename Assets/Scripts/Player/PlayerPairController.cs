using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;
using Random = UnityEngine.Random;

public class PlayerPairController : MonoBehaviour
{
    [SerializeField] Player[] managedPlayers;
    [SerializeField] GameObject playerPrefab;
    private DynamicCamera cameraScript;

    private void Awake()
    {
        managedPlayers = new Player[2];
        cameraScript = FindObjectOfType<DynamicCamera>();
    }

    void Start()
    {
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
            /*RemovePlayer(managedPlayers[0]);
            managedPlayers[0] = null;*/
            return;
        }
        Debug.Log("Player 1 joined!");
        Vector2 spawnPosition = new Vector3(30 + (5 * Random.value), 0, 30 + (5 * Random.value));
        Vector3 spawnPositionXZ = new Vector3(spawnPosition.x, 1, spawnPosition.y);
        GameObject newPlayer = Instantiate(playerPrefab, spawnPositionXZ, Quaternion.identity);

        managedPlayers[0] = newPlayer.GetComponent<Player>();
        cameraScript.AddPlayerToCamera("noId"+ (int)(Random.value*5), newPlayer.transform);
    }

    public void OnJoinPlayer2()
    {
        if (managedPlayers[1] != null)
        {
            /*RemovePlayer(managedPlayers[1]);
            managedPlayers[1] = null;*/
            return;
        }
        Debug.Log("Player 2 joined!");
        Vector2 spawnPosition = new Vector3(30 + (5 * Random.value), 0, 30 + (5 * Random.value));
        Vector3 spawnPositionXZ = new Vector3(spawnPosition.x, 1, spawnPosition.y);
        GameObject newPlayer = Instantiate(playerPrefab, spawnPositionXZ, Quaternion.identity);

        managedPlayers[1] = newPlayer.GetComponent<Player>();
        cameraScript.AddPlayerToCamera("noId" + (int)(Random.value * 5), newPlayer.transform);
    }

    private void RemovePlayer(Player player)
    {
        cameraScript.RemovePlayerFromCamera("no id");
        Destroy(player.gameObject);
    }
}
