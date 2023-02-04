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


    void Start()
    {
        cameraScript = FindObjectOfType<DynamicCamera>();
        managedPlayers = new Player[2];
    }

    public void OnMovePlayer1(InputValue value) => managedPlayers[0]?.SetPlayerMoveInput(value.Get<Vector2>());
    
    public void OnMovePlayer2(InputValue value) => managedPlayers[1]?.SetPlayerMoveInput(value.Get<Vector2>());

    public void OnStopPlayer1() => managedPlayers[0]?.SetPlayerMoveInput(Vector2.zero);
    
    public void OnStopPlayer2() => managedPlayers[1]?.SetPlayerMoveInput(Vector2.zero);

    public void OnActionPlayer1() => managedPlayers[0]?.Action();

    public void OnActionPlayer2() => managedPlayers[1]?.Action();

    public void OnJoinPlayer1(InputValue value)
    {
        Debug.Log("Player 1 joined " + value);
        Vector2 spawnPosition = Random.insideUnitCircle * 50;
        Vector3 spawnPositionXZ = new Vector3(spawnPosition.x, 0, spawnPosition.y);
        GameObject newPlayer = Instantiate(playerPrefab, spawnPositionXZ, Quaternion.identity);

        managedPlayers[0] = newPlayer.GetComponent<Player>();
        cameraScript.AddPlayerToCamera("noId"+ (int)(Random.value*5), newPlayer.transform);
    }

    public void OnJoinPlayer2()
    {
        Debug.Log("Player 2 joined");
        Vector2 spawnPosition = Random.insideUnitCircle * 50;
        Vector3 spawnPositionXZ = new Vector3(spawnPosition.x, 0, spawnPosition.y);
        GameObject newPlayer = Instantiate(playerPrefab, spawnPositionXZ, Quaternion.identity);

        managedPlayers[1] = newPlayer.GetComponent<Player>();
        cameraScript.AddPlayerToCamera("noId" + (int)(Random.value * 5), newPlayer.transform);
    }
}
