using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameValues gameValues;
    public string PlayerId;
    private Transform playerTransform;
    private Rigidbody rigidBody;
    private Interaction cutInteraction;
    private Vector2 movement;
    private float turnSmoothVeloc;
    [SerializeField] private GameObject playerModel;
    private SkinnedMeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = playerModel.GetComponent<SkinnedMeshRenderer>();
        playerTransform = transform;
        rigidBody = GetComponent<Rigidbody>();
        cutInteraction = GetComponent<Interaction>();
        rigidBody.mass = gameValues.PlayerMass;
    }

    void FixedUpdate()
    {
        Vector3 direction = new Vector3(movement.x, 0, movement.y);
        Vector3 moveForce = direction * (gameValues.MovingSpeed * 10 * Time.fixedDeltaTime);

        //* Rotation
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVeloc, gameValues.TurnSpeed);
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
        //Debug.Log(transform.name + ": I do ze aktion!");
        cutInteraction.TrySplitObject();
    }

    public void SetMaterial(Material mat)
    {
        meshRenderer.material = mat;
    }
}
