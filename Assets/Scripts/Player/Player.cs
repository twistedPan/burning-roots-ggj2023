using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string PlayerId;
    [SerializeField] private float movingSpeed = 5;
    private Transform playerTransform;
    private Rigidbody rigidBody;
    private Vector2 movement;
    [SerializeField] private float turnSmoothTime = 0.1f;
    private float turnSmoothVeloc;

    // For Fun
    [SerializeField] private GameObject bulletPrefab;

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

        rigidBody.velocity = new Vector3(moveForce.x, rigidBody.velocity.y, moveForce.z);
    }

    public void SetPlayerMoveInput(Vector2 input)
    {
        //Debug.Log("Input at " + transform.name + " is " + input);
        movement = input;
    }

    public void Action()
    {
        Debug.Log(transform.name + ": I do ze aktion!");

        // haha
        GameObject bullet = Instantiate(bulletPrefab, transform.position + transform.forward, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 100, ForceMode.Impulse);
    }
}
