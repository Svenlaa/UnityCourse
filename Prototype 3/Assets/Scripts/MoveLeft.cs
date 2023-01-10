using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerController playerControllerScript;
    float leftBound = -10;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (!playerControllerScript.gameOver)
            transform.Translate(Vector3.left * (Time.deltaTime * speed));

        if (transform.position.x < leftBound && CompareTag("Obstacle"))
            Destroy(gameObject);
    }
}