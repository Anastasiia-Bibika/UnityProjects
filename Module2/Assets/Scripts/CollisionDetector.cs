using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionDetector : MonoBehaviour
{
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            Destroy(other.gameObject);
            score++; 
            Debug.Log("Score: " + score); 
        }
        else if (other.CompareTag("Exit"))
        {
            Debug.Log("Game Over! Your score: " + score);
            
        }
    }
}
