using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab1zavd3 : MonoBehaviour
{

    public float amplitude = 45f; 
    public float frequency = 1f; 

    private float angle; 
    private float timeElapsed; 
    void Start()
    {
        
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        angle = amplitude * Mathf.Sin(2 * Mathf.PI * frequency * timeElapsed);
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
