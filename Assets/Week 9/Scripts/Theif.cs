using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Theif : Villager
{
    public Transform SpawnPoint1;
    public Transform SpawnPoint2;
    public GameObject Dagger;
    public Vector2 destinationPlaceholder;
    public float timer = 1;
    public bool CanAttack = true;
    public override ChestType CanOpen()
    {
        return ChestType.Theif;
    }

    protected override void Attack()
    {
        if (CanAttack == true)
        {
            destination = transform.position;
            base.Attack();
            Instantiate(Dagger, SpawnPoint1.position, SpawnPoint1.rotation);
            Instantiate(Dagger, SpawnPoint2.position, SpawnPoint2.rotation);
            destinationPlaceholder = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            timer = 0.5f;
        }
        

    }

    protected override void Update()
    {
        base.Update();
        Timer();
    }

    public void Timer()
    {
        if (timer > 0)
        {
            timer = timer - Time.deltaTime;
            destination = destinationPlaceholder;
            speed = 10;
        }
        else
        {
            speed = 3;

        }

    }
}
