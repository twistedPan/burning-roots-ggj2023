using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DynamicCamera : MonoBehaviour
{
    [SerializeField] private Dictionary<string, Transform> playerTransformsByPlayerId;
    [SerializeField] private float minZoom = 90f;
    [SerializeField] private float maxZoom = 40f;
    private float width = 0f;
    private float height = 0f;
    private Camera cam = null;
    private Vector3 velocity;
    [SerializeField] float smoothTime = 0.5f;
    private Transform cameraTransform;
    private Transform defaultTransform;
    private float defaultHeigth = 50f;
    [SerializeField] private Vector3 centreBetweenPlayers;

    void Start()
    {
        defaultTransform = transform; // 0,50,-50 | 45,0,0
        playerTransformsByPlayerId = new Dictionary<string, Transform>();
        cameraTransform = transform;
        centreBetweenPlayers = transform.position;
        cam = GetComponent<Camera>();
    }

    void LateUpdate()
    {
        if (playerTransformsByPlayerId.Count <= 0)
        {
            cameraTransform.position = Vector3.SmoothDamp(cameraTransform.position, defaultTransform.position, ref velocity, smoothTime);
        }
        else
        {
            centreBetweenPlayers = GetCentreBetweenPlayers();
            Vector3 newPos = new Vector3(centreBetweenPlayers.x, defaultHeigth + height / 4 + width / 8, centreBetweenPlayers.z - 30);
            cameraTransform.position = Vector3.SmoothDamp(cameraTransform.position, newPos, ref velocity, smoothTime);
            cameraTransform.rotation = Quaternion.Euler(Mathf.Lerp(60, 75, height / 135f), 0, 0);
        }

        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, Mathf.Lerp(maxZoom, minZoom, ((width > height * cam.aspect) ? width / 200f : height / 100f)), Time.deltaTime);
    }

    public void AddPlayerToCamera(string playerId, Transform playerTransform)
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
        Bounds bound = new Bounds(playerTransformsByPlayerId.Values.First().position, Vector3.zero);
        foreach (var currTransform in playerTransformsByPlayerId.Values)
        {
            bound.Encapsulate(currTransform.position);
        }
        width = bound.size.x;
        height = bound.size.z;
        return bound.center;
    }
}
