using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformButton : MonoBehaviour
{
    public GameObject Platform;
    public GameObject Position1;
    public GameObject Position2;
    public int PlatformPosition = 1;
    public bool TouchingButton = false;
    Rigidbody2D rb;
  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {

        //If the player is touching the switch and pressing the E key, switch platform position.
        if (RedSquare.Switch == true && TouchingButton == true)
        {
            if (PlatformPosition == 1)
            {
                Platform.transform.position = Position2.transform.position;
                PlatformPosition = 2;
            }
            else if (PlatformPosition == 2) 
            {
                Platform.transform.position = Position1.transform.position;
                PlatformPosition = 1;
            }
        }
    }

    //This code checks if the player is touching the button.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        TouchingButton = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        TouchingButton = false;
    }
}
