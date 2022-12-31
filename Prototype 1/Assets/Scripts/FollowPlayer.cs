using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    Vector3 offset = new Vector3(0, 5, -7);
    
    void LateUpdate()
    {
        // Offset camera by adding the Offset
        transform.position = player.transform.position + offset;
    }
}