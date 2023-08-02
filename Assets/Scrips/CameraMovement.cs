using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    private float moveSpeed = 10f;
    private Vector3 moveVector;

    void Start()
    {
        moveVector = new Vector3(0, 0, 0);
    }

    void Update()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.z = Input.GetAxisRaw("Vertical");

        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0) {
            transform.position += moveSpeed * moveVector * Time.deltaTime;
        }

    } 
}
