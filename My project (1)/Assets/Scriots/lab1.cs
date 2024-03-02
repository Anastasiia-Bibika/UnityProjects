using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class lab1 : MonoBehaviour
{
    
    public GameObject gravityObject;
    private Rigidbody rb;

    private bool gravityEnabled = false;

    void Start()
    {
        rb = gravityObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravityEnabled = !gravityEnabled;
            rb.useGravity = gravityEnabled;
        }
    }
}
