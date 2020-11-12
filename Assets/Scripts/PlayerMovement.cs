using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private string InputAxisX = "Horizontal";
    private string InputAxisY = "Vertical";

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
        float moveXAxis = Input.GetAxis(InputAxisX);
        float moveYAxis = Input.GetAxis(InputAxisY);

        ApplyInput(moveXAxis, moveYAxis);
    }


    private void ApplyInput(float moveX, float moveY)
    {
        MoveXAxis(moveX);
        MoveYAxis(moveY);
    }   

    private void MoveXAxis(float input)
    {
        rigidBody.AddForce(new Vector3(1, 0, 0) * input * movingSpeed, ForceMode.Force);
    }

    private void MoveYAxis(float input)
    {
        rigidBody.AddForce(new Vector3(0 ,1 ,0) * input * movingSpeed, ForceMode.Force);
    }

 

}
