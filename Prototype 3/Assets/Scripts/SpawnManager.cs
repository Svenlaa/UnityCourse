using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new(25, 0, 0);

    private float startDelay = 2;
    private float repeatRate = 3;

    private PlayerController playerControllerScript;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void SpawnObstacle()
    {
        if (!playerControllerScript.gameOver)
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}