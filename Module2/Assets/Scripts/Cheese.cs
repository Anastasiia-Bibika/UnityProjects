using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese : MonoBehaviour
{
    public string title;
    public int calory;

    Cheese(string title, int calory)
    {
        this.title = title;
        this.calory = calory;
    }
}
