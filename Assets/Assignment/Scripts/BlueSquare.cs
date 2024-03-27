using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSquare : CharacterController
{
    

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }

    public override void Ability()
    {

        float check = 0;

        //Checking if the player is jumping or not/making the jump cooldown.
        while (check < 2)
        {
            if (count == 0)
            {
                //Activating the jump coroutine.
                base.Ability();
                StartCoroutine(Jump());
            }
            if (count >= 2.5f)
            {
                count = 0;
                StopAllCoroutines();
            }
            check = check + 1;
        }
        
    }

    //Jump coroutine.
    IEnumerator Jump()
    {
        count = 0;
        rb.AddForce(transform.up * 600f);
        while (count < 4)
        {
            count = count + Time.deltaTime;
            yield return null;
        }
        

    }
}
