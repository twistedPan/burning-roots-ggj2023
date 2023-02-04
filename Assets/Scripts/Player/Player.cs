using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform playerTransform;
    [SerializeField] private float movingSpeed = 5;
    private Vector2 movement;

    void Start()
    {
        playerTransform = transform;
    }

    void Update()
    {
        Vector3 moveDirection = new Vector3(movement.x, 0, movement.y);
        playerTransform.Translate(moveDirection * (movingSpeed * Time.deltaTime));
    }

    public void MoveByInput(Vector2 input)
    {
        //Debug.Log("Input at " + transform.name + " is " + input);
        movement = input;
    }

    public void Action()
    {
        Debug.Log(transform.name + ": I do ze aktion!");
    }
}
