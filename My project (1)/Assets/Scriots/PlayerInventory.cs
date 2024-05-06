using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCoins { get; private set; }

    public void CoinCollected()
    {
        NumberOfCoins++;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnTriggerEnter(Colider other)
    //{
        //if (other.CompareTag("coin"))
        //{
            //other.gameObject.SetActive(false);
        //}
    //}
}
