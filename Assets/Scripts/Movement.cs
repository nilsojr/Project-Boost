using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float thrustPower = 500f;
    [SerializeField] float rotationPower = 1f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * thrustPower * Time.deltaTime);
        }
    }

    private void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back * rotationPower * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * rotationPower * Time.deltaTime);
        }
    }
}