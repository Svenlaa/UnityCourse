using UnityEngine;
using UnityEngine.Serialization;

public class FirstPersonCamera : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    [FormerlySerializedAs("c")] public float cameraRotationY;
    [FormerlySerializedAs("playerRotation")] [FormerlySerializedAs("playerRoatioin")] [FormerlySerializedAs("p")] public float playerRotationY;
    public float r;
    
    void LateUpdate()
    {
        // Offset camera by adding the Offset
        transform.position = player.transform.position + offset;

        playerRotationY = player.transform.rotation.y;
        cameraRotationY = transform.rotation.y;

        transform.Rotate(Vector3.up, playerRotationY - cameraRotationY);
    }
}