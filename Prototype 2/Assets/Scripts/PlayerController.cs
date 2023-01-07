using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public float zUpper = 4.0f;
    public GameObject projectilePrefab;


    private void Update()
    {
        if (transform.position.x < -xRange)
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        if (transform.position.x > xRange)
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        if (transform.position.z > zUpper)
            transform.position = new Vector3(transform.position.x, transform.position.y, zUpper);
        if (transform.position.z < 0)
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);

        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * speed));
        transform.Translate(Vector3.forward * (verticalInput * Time.deltaTime * speed));
    }
}