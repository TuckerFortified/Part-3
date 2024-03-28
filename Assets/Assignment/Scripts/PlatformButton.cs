using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformButton : MonoBehaviour
{
    public GameObject Platform;
    public int PlatformPosition = 1;
    public bool TouchingButton = false;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (RedSquare.Switch == true && TouchingButton == true)
        {
            if (PlatformPosition == 1)
            {
                PlatformPosition = 2;
            }
            else if (PlatformPosition == 2) 
            {
                PlatformPosition = 1;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TouchingButton = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        TouchingButton = false;
    }
}
