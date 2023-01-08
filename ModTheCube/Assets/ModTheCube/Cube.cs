using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(1f, 0.3f, 1f, 0.4f);
    }
    
    void Update()
    {
        transform.Rotate(15.0f * Time.deltaTime, 3.0f * Time.deltaTime, 17.0f * Time.deltaTime);
    }
}
