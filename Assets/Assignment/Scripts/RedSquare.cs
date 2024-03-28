using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RedSquare : CharacterController
{
    //This is my static variable.
    public static bool Switch = false;

    
    public override void Start()
    {
        base.Start();
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
        yield return null;
        Switch = false;
        while (count < 2.5f)
        {
            
            count = count + Time.deltaTime;
            yield return null;
        }
        
        yield return null;

    }
}
