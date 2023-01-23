using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 10.0f;
    private float xRange = 7;

    private void Update()
    {
        MovePlayer();
        ConstrainPlayerPosition();
    }

    void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (speed * Time.deltaTime * horizontalInput));
    }

    void ConstrainPlayerPosition()
    {
        Vector3 pos = transform.position;

        if (pos.x > xRange)
            transform.position = new Vector3(xRange, pos.y, pos.z);

        else if (pos.x < -xRange)
            transform.position = new Vector3(-xRange, pos.y, pos.z);
    }
}