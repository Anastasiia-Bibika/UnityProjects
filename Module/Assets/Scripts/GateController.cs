using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
  
    void Start()
    {
        
    }
    public float raiseHeight = 50f;
    public float raiseAngle = 100f;
    public float raiseSpeed = 2f;
    public float detectionDistance = 5f; 
    public Transform car; 
    private bool isRaised = false;

    void Update()
    {
        float distanceToCar = Vector3.Distance(transform.position, car.position);

       
        if (distanceToCar < detectionDistance && !isRaised)
        {
          
            RaiseGate();
        }
    }

    void RaiseGate()
        {
            Vector3 raisedPosition = transform.position + new Vector3(0f, raiseHeight, 0f);
            transform.position = Vector3.Lerp(transform.position, raisedPosition, raiseSpeed * Time.deltaTime);
            isRaised = true;
        }
    
}
