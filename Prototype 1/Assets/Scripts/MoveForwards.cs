using UnityEngine;

public class MoveForwards : MonoBehaviour
{
    public GameObject vehicle;
    public float speed;

    void Update()
    {
        vehicle.transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }
}
