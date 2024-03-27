using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    bool movingLeft = false;
    bool movingRight = false;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    public virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
       
    }

    // Update is called once per frame
    public virtual void Update()
    {
        Movement();
        if (Input.GetKeyDown("e"))
        {
            Ability();
        }
    }

    //Function for player movement.
    public virtual void Movement() 
    {

        //Checking if the player is moving left or right, or not moving at all.
        if (Input.GetKeyDown("a"))
        {
            movingLeft = true;
        }
        if (Input.GetKeyDown("d"))
        {
            movingRight = true;
        }
        if (Input.GetKeyUp("a"))
        {
            movingLeft = false;
        }
        if (Input.GetKeyUp("d"))
        {
            movingRight = false;
        }


        //This code actually moves the player.
        if (movingRight == true)
        {
            rb.AddForce(transform.right * 2f);
        }
        if (movingLeft == true)
        {
            rb.AddForce(-transform.right * 2f);
        }
        
    }

    //This function will be inherited by the child classes and will make the players abilities activate
    public virtual void Ability()
    {
        movingLeft = false;
        movingRight = false;
    }


}
