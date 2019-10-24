using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCollisionScript : MonoBehaviour
{
    public int points;
    public SpotLightShow LightsController;
    public SpotLightSideShow LeftSideshowController;
    public SpotLightSideShow RightSideshowController;

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
                LeftSideshowController.StartCoroutine("EnableFlickering");
                LeftSideshowController.InvokeRepeating("FlickerLights", 0f, 0.01f);
                RightSideshowController.StartCoroutine("EnableFlickering");
                RightSideshowController.InvokeRepeating("FlickerLights", 0.05f, 0.01f);
                break;
            case 2:
                ScoreboardHandler.Instance.AddTwoPointer();
                LeftSideshowController.StartCoroutine("EnableFlickering");
                LeftSideshowController.InvokeRepeating("FlickerLights", 0f, 0.01f);
                RightSideshowController.StartCoroutine("EnableFlickering");
                RightSideshowController.InvokeRepeating("FlickerLights", 0.05f, 0.01f);
                break;
            default:
                ScoreboardHandler.Instance.AddThreePointer();
                LeftSideshowController.StartCoroutine("EnableFlickering");
                LeftSideshowController.InvokeRepeating("FlickerLights", 0f, 0.01f);
                RightSideshowController.StartCoroutine("EnableFlickering");
                RightSideshowController.InvokeRepeating("FlickerLights", 0.05f, 0.01f);

                break;
        }
    }

   

}
