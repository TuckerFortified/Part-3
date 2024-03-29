using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject Blocker;
    public GameObject Teleport;

    //This script makes it so that when the blue square lands on the plate, a door will teleport away so that the red square can progress.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Blocker.transform.position = Teleport.transform.position;
    }

}
