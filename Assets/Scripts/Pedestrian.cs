using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedestrian : MonoBehaviour
{
    public string name;
    public bool masked;
    public List<GameObject> WayPoints;
    
    private int currentWP;
    

    private void Start() {
        currentWP = 0;
    }

    private void Update()
    {
        pedestrianMovement();
    }

    private void pedestrianMovement()
    {
        float dist = Vector3.Distance(WayPoints[currentWP].transform.position, transform.position);
        transform.position = Vector3.Lerp(transform.position, WayPoints[currentWP].transform.position, Time.deltaTime/2f);
        if(dist < 1f) {
            if(currentWP < WayPoints.Count-1) currentWP++;
            else currentWP = 0;
        }
    }

}
