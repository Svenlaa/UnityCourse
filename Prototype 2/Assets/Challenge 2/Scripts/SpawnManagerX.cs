using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float minSpawnInterval = 3.0f;
    private float maxSpawnInterval = 5.0f;

    // Start is called before the first frame update
    private void Start()
    {
        Invoke(nameof(SpawnRandomBall), startDelay + Random.Range(minSpawnInterval, maxSpawnInterval));
    }

    // Spawn random ball at random x position at top of play area
    private void SpawnRandomBall ()
    {
        Invoke(nameof(SpawnRandomBall),  Random.Range(minSpawnInterval, maxSpawnInterval));
        
        // Generate random ball index and random spawn position
        var spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        var ball = ballPrefabs[Random.Range(0, ballPrefabs.Length)];
        
        // instantiate ball at random spawn location
        Instantiate(ball, spawnPos, ball.transform.rotation);
    }
}
