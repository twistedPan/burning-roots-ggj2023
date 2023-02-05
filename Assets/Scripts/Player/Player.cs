using System;
using System.Collections.Generic;
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
    [SerializeField] private GameObject playerBodyModel;
    [SerializeField] private GameObject playerDetailModel;
    [SerializeField] private GameObject playerBladeModel;
    [SerializeField] private GameObject playerHoverPadModel;
    private Animation cutAnimation;
    private List<SkinnedMeshRenderer> meshRenderers;

    private void Awake()
    {
        playerTransform = transform;
        rigidBody = GetComponent<Rigidbody>();
        cutInteraction = GetComponent<Interaction>();
        rigidBody.mass = gameValues.PlayerMass;
        cutAnimation = transform.Find("Beehicle_rigged_2").GetComponent<Animation>();

        meshRenderers = new List<SkinnedMeshRenderer>();
        meshRenderers.Add(playerBodyModel.GetComponent<SkinnedMeshRenderer>());
        meshRenderers.Add(playerDetailModel.GetComponent<SkinnedMeshRenderer>());
        meshRenderers.Add(playerBladeModel.GetComponent<SkinnedMeshRenderer>());
        meshRenderers.Add(playerHoverPadModel.GetComponent<SkinnedMeshRenderer>());

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
        if (cutAnimation.IsPlaying("Cinema_4D_Basis")) return;
        cutAnimation.Play("Cinema_4D_Basis");
        Invoke("cutIt", 0.5f);
        
    }

    private void cutIt()
    {
        cutInteraction.TrySplitObject();
    }

    public void SetMaterial(Material[] mats)
    {
        for (int i = 0; i < meshRenderers.Count; i++)
        {
            SkinnedMeshRenderer meshRend = meshRenderers[i];
            meshRend.material = mats[i];
        }
    }
}
