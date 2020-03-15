using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 1000f;

    public float forceApplied = 40f;

    public void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {

            rb.AddForce(forceApplied * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("a"))
        {

            rb.AddForce(-forceApplied * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
    }
}
