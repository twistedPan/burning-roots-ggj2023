using System;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    [SerializeField] private List<string> playerIds;
    [SerializeField] private GameObject playerPrefab;
    private List<PlayerInput> playerPairs;
    [SerializeField] private float spawnRadius = 8f;

    void Awake()
    {
        playerPairs = new List<PlayerInput>();
    }

    public void OnPlayerJoined(PlayerInput playerInput)
    {
        Debug.Log("Player Pair Joined");
        playerPairs.Add(playerInput);

        switch (playerPairs.Count)
        {
            case 0:
                return;
            case 1:
                playerInput.defaultActionMap = "Player1";
                break;
            case 2:
                playerInput.defaultActionMap = "Player2";
                break;
            default:
                break;
        }
    }
}

