using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 40f;
    public float zoomspeed = 3000f;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        float scroll = Input.GetAxisRaw("Mouse ScrollWheel");

        transform.Translate(new Vector3(horizontal * speed, scroll * zoomspeed, vertical * speed) * Time.deltaTime, Space.World);
    }
}
