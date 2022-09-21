using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;

    public float xSensitivity = 300f;
    public float ySensitivity = 300f;

    public void Processlook(Vector2 input) 
    {
        float mouseX = input.x;
        float mouseY = input.y;
        //This Calculates camera rotation for looking up and down.
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -100f, 100f);
        //This applies to our camera transform. 
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        //this rotates player to look left and right.
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
    }
}
