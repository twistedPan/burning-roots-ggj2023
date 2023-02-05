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
    [SerializeField] private Material[] bodyMaterials;
    [SerializeField] private Material[] detailsMaterials;
    [SerializeField] private Material[] bladeMaterials;
    [SerializeField] private Material[] hoverpadMaterials;
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

    public Material[] GetMaterialForPlayer()
    {
        Material[] mats = new Material[4];
        mats[0] = bodyMaterials[materialIndex++ % bodyMaterials.Length];
        mats[1] = detailsMaterials[UnityEngine.Random.Range(0, 4)];
        mats[2] = bladeMaterials[UnityEngine.Random.Range(0, 4)];
        mats[3] = hoverpadMaterials[UnityEngine.Random.Range(0, 4)];
        return mats;
    }
}

