using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Theif : Villager
{
    public Transform SpawnPoint1;
    public Transform SpawnPoint2;
    public GameObject Dagger;
    public Vector2 destinationPlaceholder;
    public float timer = 1;
    public bool CanAttack = true;
    Coroutine dashing;
    
    
    public override ChestType CanOpen()
    {
        return ChestType.Theif;
    }

    protected override void Attack()
    {   
        if (dashing != null)
        {
            StopCoroutine(dashing);
        }
        dashing = StartCoroutine(Dash());
    }

    IEnumerator Dash()
    {
    
        
        destination = transform.position;
        destinationPlaceholder = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        destination = destinationPlaceholder;
        speed = 10;
        while (speed > 3)
        {
            yield return null;
        }
        base.Attack();
        yield return new WaitForSeconds(0.1f);
        Instantiate(Dagger, SpawnPoint1.position, SpawnPoint1.rotation);
        Instantiate(Dagger, SpawnPoint2.position, SpawnPoint2.rotation);


            
        
    }

    protected override void Update()
    {
        base.Update();
        //Timer();
    }

    public void Timer()
    {
        if (timer > 0)
        {
            timer = timer - Time.deltaTime;
            
            speed = 10;
            CanAttack = false;
        }
        else
        {
            speed = 3;
            CanAttack = true;

        }

    }

    public override string ToString()
    {
        return "Hello bro";
    }
}
