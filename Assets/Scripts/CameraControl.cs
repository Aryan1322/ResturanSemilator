using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject player;
    public float sensitivity;




    public void CameraControls()
    {
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = Input.GetAxis("Mouse Y");

        transform.RotateAround(player.transform.position, -Vector3.up, rotateHorizontal * sensitivity);
        transform.RotateAround(Vector3.zero, transform.right, rotateVertical * sensitivity);
    }




    // Update is called once per frame
    void FixedUpdate()
    {
        CameraControls();
    }
}
