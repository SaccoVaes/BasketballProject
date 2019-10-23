using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCollisionScript : MonoBehaviour
{
    public int points;
    public SpotLightShow controller;
    private void OnTriggerEnter(Collider obj)
    {
        Debug.Log("Player Scored a point!.");

        if (obj.tag != "Ball")
        {
            return;
        }

        switch (points)
        {
            case 1:
                ScoreboardHandler.Instance.AddOnePointer();
                break;
            case 2:
                ScoreboardHandler.Instance.AddTwoPointer();
                //controller.GenerateRandomLights();
                break;
            default:
                ScoreboardHandler.Instance.AddThreePointer();
                controller.FlickerLights();
                break;
        }
    }
}
