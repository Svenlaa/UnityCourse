using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnDelay = 1.5f;
    
    private float timer;
    
    private void Update()
    {
        timer += Time.deltaTime;

        if (!Input.GetKeyDown(KeyCode.Space) || timer < spawnDelay) return;
        
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        timer = 0;
    }
}
