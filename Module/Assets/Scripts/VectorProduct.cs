using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class VectorProduct : MonoBehaviour

{
    void Start()
    {
        Vector3 vec1 = new Vector3(1, -5, 7);
        Vector3 vec2 = new Vector3(2, 0, -6);
        Vector3 crossProduct = Vector3.Cross(vec1, vec2);
        Debug.Log("Cross product: " + crossProduct);
    }
    public float speed = 5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
