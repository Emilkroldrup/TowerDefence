using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("Movement Boundaries")]
    public Vector3 min;
    public Vector3 max;
    [Header("Movement Speed")]
    public float speed = 10.0f;

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(xInput, 0, zInput) * speed * Time.deltaTime;
        Vector3 newPosition = transform.position + move;

        newPosition.x = Mathf.Clamp(newPosition.x, min.x, max.x);
        newPosition.z = Mathf.Clamp(newPosition.z, min.z, max.z);

        transform.position = newPosition;
    }
}
