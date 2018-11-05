using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPMove : MonoBehaviour {

    [SerializeField]
    Transform[] waypoints;

    public float minDistance = 10f;
    int i = 0;

    //public Transform waypoint;
    Rigidbody rb;
    public float speed = 10000;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

	void Update ()
    {
        transform.LookAt(waypoints[i]);
        rb.AddForce(transform.forward * speed);

        if (Vector3.Distance(transform.position, waypoints[i].transform.position) <= minDistance)
        {
            i++;
            if(i == 6){
                i = 0;
            }
        }
    }
}
