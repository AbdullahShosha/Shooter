using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    float MouseX, MouseY,xRotation;
    [Range(300,600)]public float Sesetivity = 400f;
    public Transform Player;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        MouseX = Input.GetAxis("Mouse X") * Sesetivity * Time.deltaTime;
        MouseY = Input.GetAxis("Mouse Y") * Sesetivity * Time.deltaTime;

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        
        Player.Rotate(Vector3.up * MouseX);
    }
}
