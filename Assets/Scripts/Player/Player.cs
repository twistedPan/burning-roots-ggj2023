using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float movingSpeed = 5;
    private Transform playerTransform;
    private Rigidbody rigidBody;
    private Vector2 movement;
    private float turnSmoothTime = 0.1f;
    private float turnSmoothVeloc;

    void Start()
    {
        playerTransform = transform;
        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 direction = new Vector3(movement.x, 0, movement.y);
        Vector3 moveForce = direction * (movingSpeed * 10 * Time.fixedDeltaTime);

        //* Rotation
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVeloc, turnSmoothTime);
        if (direction.magnitude > 0)
        {
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
        }

        rigidBody.velocity = new Vector3(moveForce.x, 0, moveForce.z);
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
