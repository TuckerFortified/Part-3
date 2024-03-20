using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    Coroutine Building;
    public GameObject building1;
    public GameObject building2;
    public GameObject building3;
    public float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        building1.transform.localScale = Vector3.zero;
        building2.transform.localScale = Vector3.zero;
        building3.transform.localScale = Vector3.zero;
        StartCoroutine(Build());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Build()
    {
        while (timer < 1)
        {
            building1.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (timer % 10));
            building2.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (timer % 10));
            building3.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (timer % 10));
            timer = timer + Time.deltaTime;
        } 
        yield return null;
        
    }
}
