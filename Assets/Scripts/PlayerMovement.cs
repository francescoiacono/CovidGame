using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";

    private Rigidbody rigidBody;

    public float rotationRate = 360;
    public float movingSpeed = 10;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.centerOfMass = Vector3.zero;
        rigidBody.inertiaTensorRotation = Quaternion.identity;
    }

    void FixedUpdate()
    {
        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);

        ApplyInput(moveAxis, turnAxis);
    }


    private void ApplyInput(float moveInput, float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }

    private void Move(float input)
    {
        rigidBody.AddForce(transform.forward * input * movingSpeed, ForceMode.Force);
    }

    private void Turn(float input)
    {
        transform.Rotate(0, rotationRate * input * Time.deltaTime, 0);
    }

}
