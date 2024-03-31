using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Debug = UnityEngine.Debug;


public class LoginValidation : MonoBehaviour
{
    public InputField username;
    public InputField password;

    public GameObject[] canvas;


    public void CheckValidation()
    {
        string uname = username.text;
        string pass = password.text;

        if (uname == "pumpa@gmail.com" && pass == "LyaLya")
        {
            Debug.Log("Login Successfully");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (uname == "" || pass == "")
        {
            Debug.Log("Please Enter Correct Username and Password");
        }
        else
        {
            Debug.Log("Please Enter Username and Password");
        }
    }
}
