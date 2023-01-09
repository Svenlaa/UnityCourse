using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 10;
    public float gravityModifier = 1;
    public bool isOnGround = true;
    
    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space) || !isOnGround) return;
        
        playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isOnGround = false;

    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}

