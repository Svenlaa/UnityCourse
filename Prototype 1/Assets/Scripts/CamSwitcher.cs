using System;
using UnityEditor;
using UnityEngine;

public class CamSwitcher : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public bool useCam1 = true;
    private float prevInput;

    private void Start()
    {
        cam1.SetActive(useCam1);
        cam2.SetActive(!useCam1);
    }

    private void Update()
    {
        
        float currentInput = Input.GetAxis("Jump");
        if (currentInput == 1 && prevInput == 0)
        {
            useCam1 = !useCam1;
            cam1.SetActive(useCam1);
            cam2.SetActive(!useCam1);
        }

        prevInput = currentInput;
    }
}
