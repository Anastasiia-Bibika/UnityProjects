using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class lab1zavd2lit : MonoBehaviour
{
    public float speed = 5f; 
    public float radius = 1f; 
    public float heightIncrease = 4f;

    private float angle = 0f; 
    private float height = 0f; 

    void Start()
    {
        
    }

    
    void Update()
    {
       
        float x = radius * Mathf.Cos(angle);
        float y = height;
        float z = radius * Mathf.Sin(angle);
        transform.position = new Vector3(x, y, z);

        angle += speed * Time.deltaTime;
        height += heightIncrease * Time.deltaTime;
    }
}
