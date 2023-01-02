using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    public GameObject propellor;
    int turnSpeed = 360;
    
    // Update is called once per frame
    void Update()
    {
        propellor.transform.Rotate(Vector3.forward, Time.deltaTime * turnSpeed);
    }
}
