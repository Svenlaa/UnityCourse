using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private GameObject focalPoint;
    private Rigidbody playerRb;

    private void Start()
    {
        focalPoint = GameObject.Find("Focal Point");
        playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(focalPoint.transform.forward * (speed * verticalInput));
    }
}