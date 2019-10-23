using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * NOTES:
 * I want this class to have:
 * -2 public fields that store Collider components.
 * -A coroutine to turn the collider into a trigger for 2 seconds.
 * 
 * */

public class BasketCollissionScript : MonoBehaviour
{
    public BoxCollider EntryCollider; 
    public BoxCollider ExitCollider;
    private void Start()
    {
        //StartCoroutine(EnableExitCollider());
    }
    private void OnTriggerEnter(Collider obj)
    {
        Debug.Log("Something entered the trigger");

        if (obj.tag != "Ball")
        {
            return;
        }
        Debug.Log("Ball entered the collider!");
        ScoreboardHandler.Instance.AddOnePointer();
        StartCoroutine(EnableExitCollider());
    }

    IEnumerator EnableExitCollider()
    {
        ExitCollider.isTrigger = true;
        Debug.Log("Bottom collision disabled");
        yield return new WaitForSeconds(2);
        ExitCollider.isTrigger = false;
        Debug.Log("Bottom collision enabled");
    }

        
}
