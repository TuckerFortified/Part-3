using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class RedSquare : CharacterController
{
    public GameObject Swipe;
    public GameObject Hide;
    public GameObject Show;

    //This is the text for the ability cooldown.
    public TextMeshProUGUI AbilityCooldown;

    //This is my static variable.
    public static bool Switch = false;

    
    public override void Start()
    {
        base.Start();

        //Hiding the swipe image.
        Swipe.transform.position = Hide.transform.position;

        //Making the ability cooldown text start blank.
        AbilityCooldown.text = " ";
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

        AbilityCooldown.text = "Ability Cooldown: 3";

        yield return null;
        Switch = false;
        while (count < 2.5f)
        {
            if (count > 1)
            {
                //Hiding the swipe image.
                Swipe.transform.position = Hide.transform.position;
            }
            if (count > 0.83f && count < 1.66f)
            {
                AbilityCooldown.text = "Ability Cooldown: 2";
            }
            else if (count > 1.67)
            {
                AbilityCooldown.text = "Ability Cooldown: 1";
            }
            count = count + Time.deltaTime; 
            yield return null;

        }

        AbilityCooldown.text = " ";
        yield return null;

    }
}
