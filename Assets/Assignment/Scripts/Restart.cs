using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    //Here is the required static function that will load the main level when called.
    public static void restart() 
    {
        SceneManager.LoadScene("Assignment 3");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("End Screen");
    }
}
