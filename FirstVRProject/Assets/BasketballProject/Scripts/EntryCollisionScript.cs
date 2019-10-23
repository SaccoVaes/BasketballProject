using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryCollisionScript : MonoBehaviour
{
    public BoxCollider ExitCollider;

    private void OnTriggerEnter(Collider obj)
    {
        Debug.Log("Something entered the trigger");

        if (obj.tag != "Ball")
        {
            return;
        }
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
