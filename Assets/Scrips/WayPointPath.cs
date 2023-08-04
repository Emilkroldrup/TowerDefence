using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointPath : MonoBehaviour
{
    public GameObject[] waypoints;
    public float moveSpeed;
    public int targetWayPoint;

    void Start()
    {
        transform.position = waypoints[0].transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[targetWayPoint].transform.position, moveSpeed * Time.deltaTime);

        if (transform.position == waypoints[targetWayPoint].transform.position)
        {
            targetWayPoint++;
        }
    }
}