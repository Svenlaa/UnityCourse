using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 10.0f;
    float turnSpeed = 25.0f;
    float horizontalInput;
    float forwardInput;
    
    void Update()
    {
        // Move the thing forward.
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * (Time.deltaTime * speed * forwardInput));
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
