using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RedSquare : CharacterController
{
    public GameObject Swipe;
    public GameObject Hide;
    public GameObject Show;

    //This is my static variable.
    public static bool Switch = false;

    
    public override void Start()
    {
        base.Start();

        //Hiding the swipe image.
        Swipe.transform.position = Hide.transform.position;
    }

    
    public override void Update()
    {
        base.Update();
    }

    public override void Ability()
    {

        float check = 0;

        //Checking if the player is already flipping the switch.
        while (check < 2)
        {
            if (count == 0)
            {
                //Activating the switch coroutine.
                base.Ability();
                StartCoroutine(HitSwitch());
            }
            if (count >= 2.5f)
            {
                count = 0;
                StopAllCoroutines();
            }
            check = check + 1;
        }

    }

    //Coroutine that makes the red square flip the switch infront of it.
    IEnumerator HitSwitch()
    {
        count = 0;
        Switch = true;
        
        //This code teleports the swipe image infront of the red square. Yes, I chose to do it this way because I felt like it.
        Swipe.transform.position = Show.transform.position;
        
        yield return null;
        Switch = false;
        while (count < 2.5f)
        {
            if (count > 1)
            {
                //Hiding the swipe image.
                Swipe.transform.position = Hide.transform.position;
            }
            count = count + Time.deltaTime;
            yield return null;
        }
        
        yield return null;

    }
}
