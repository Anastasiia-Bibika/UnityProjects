using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class lab1zavd2litA : MonoBehaviour
{
    public float speed = 5f; 
    public float switchTime = 2f; 

    private Vector3 direction = Vector3.right; 
    private float timer = 0f; 
    void Start()
    {
        
    }

    
    void Update()
    {
        
        transform.Translate(direction * speed * Time.deltaTime);
        timer += Time.deltaTime;
        if (timer >= switchTime)
        {
            direction *= -1;
            timer = 0f;
        }


    }
    }
