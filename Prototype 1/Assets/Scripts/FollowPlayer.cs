using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    void LateUpdate()
    {
        // Offset camera by adding the Offset
        transform.position = player.transform.position + offset;
    }
}