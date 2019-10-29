using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTesting : MonoBehaviour
{
    public float maxRayDistance = 25;

    //Use fixedUpdate, because we are using physics engine. Ray do use physics.
    void FixedUpdate()
    {
        //A ray is an line with an origen and a direction.
        Ray ray = new Ray(transform.position, Vector3.right);
        //RaycastHit 
        RaycastHit hit;

        //You can also add a layer 
        RaycastHit[] hits = Physics.RaycastAll(ray, maxRayDistance);

        //Use debug.drawline(Origin position, Vector3 point to draw to, color);
        Debug.DrawLine(transform.position, transform.position + Vector3.right * maxRayDistance, Color.red);

        //Check if the raycast hit an object...
        //If we hit something it returns true
        if (Physics.Raycast(ray,out hit, maxRayDistance))
        {
            Debug.Log("You hit a ray!");

            //This way, you access the hit.point (The point where the raycast hits the obstacle) and sends a green line up with a range of 5f.
            Debug.DrawLine(hit.point, hit.point + Vector3.up * 5
                , Color.green);
        }

        //Forloop to loop through all raycast hits in the array
        foreach(RaycastHit h in hits)
        {
            Debug.DrawLine(h.point, h.point + Vector3.up * 5,Color.gray);
            Debug.Log(h.distance);
        }
    }
}
