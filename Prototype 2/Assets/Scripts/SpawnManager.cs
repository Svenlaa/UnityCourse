using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 25;


    private float startDelay = 2;
    private float interval = 1.5f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), startDelay, interval);
    }

    private void SpawnRandomAnimal()
    {
        var animalIndex = Random.Range(0, animalPrefabs.Length);
        var animal = animalPrefabs[animalIndex];
        var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animal, spawnPos, animal.transform.rotation);
    }
}