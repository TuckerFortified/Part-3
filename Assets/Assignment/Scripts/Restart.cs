using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public static void restart() 
    {
        SceneManager.LoadScene("Assignment 3");
    }
}
