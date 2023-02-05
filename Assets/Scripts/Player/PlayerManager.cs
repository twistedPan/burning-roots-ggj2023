using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameValues gameValues;
    [SerializeField] private GameObject playerPrefab;
    private List<PlayerInput> playerPairs;
    private PlayerInputManager playerInputManager;
    [field:SerializeField] public Transform[] PossibleSpawnPoints { get; private set; }
    [SerializeField] private Material[] playerMaterials;
    private int materialIndex;

    void Awake()
    {
        materialIndex = 0;
        playerPairs = new List<PlayerInput>();
        playerInputManager = GetComponent<PlayerInputManager>();
    }

    public void OnPlayerJoined(PlayerInput playerInput)
    {
        if (!playerInputManager.joiningEnabled) return;


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

        if (playerPairs.Count == gameValues.MaxPlayerControllerCount)
        {
            playerInputManager.DisableJoining();
        }
    }

    public Material GetMaterialForPlayer()
    {
        return playerMaterials[materialIndex++ % playerMaterials.Length];
    }
}

