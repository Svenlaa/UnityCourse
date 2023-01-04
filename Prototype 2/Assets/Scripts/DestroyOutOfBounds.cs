using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperBound = 30;
    private float lowerBound = -10;

    private void Update()
    {
        if (transform.position.z > upperBound)
            Destroy(gameObject);
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Animal Died");
        }
    }
}