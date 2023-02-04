using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicCamera : MonoBehaviour
{
    [SerializeField] private Dictionary<string, Transform> playerTransformsByPlayerId;
    [SerializeField] private Vector3 centreBetweenPlayers;
    private Transform cameraTransform;
    public float cameraHeight = 50;
    [SerializeField] private Vector3 cameraOffset = Vector3.up;

    void Start()
    {
        playerTransformsByPlayerId = new Dictionary<string, Transform>();
        cameraTransform = transform;
        centreBetweenPlayers = transform.position;
    }

    void Update()
    {
        if (playerTransformsByPlayerId.Count <= 0) return;

        centreBetweenPlayers = GetCentreBetweenPlayers() + cameraOffset * cameraHeight;
        cameraTransform.position = centreBetweenPlayers;
    }

    public void AddPlayerToCamera(string playerId,Transform playerTransform)
    {
        if (playerTransformsByPlayerId.ContainsKey(playerId)) return;
        playerTransformsByPlayerId.Add(playerId, playerTransform);
    }

    public void RemovePlayerFromCamera(string playerId)
    {
        if (playerTransformsByPlayerId.ContainsKey(playerId))
        {
            playerTransformsByPlayerId.Remove(playerId);
        }
    }

    private Vector3 GetCentreBetweenPlayers()
    {
        Vector3 cumulatedVectors = Vector3.zero;
        foreach (var transform in playerTransformsByPlayerId.Values)
        {
            cumulatedVectors += transform.position;
        }

        return cumulatedVectors / playerTransformsByPlayerId.Count;
    }
}
