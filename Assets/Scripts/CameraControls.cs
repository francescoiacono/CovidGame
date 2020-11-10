using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    public Transform Player;
    private float Height;
    private float Dist;

    private void FixedUpdate()
    {
        transform.position = new Vector3(Player.position.x, Player.position.y, transform.position.z);

    }

}
