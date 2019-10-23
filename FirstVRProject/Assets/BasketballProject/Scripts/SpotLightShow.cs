using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightShow : MonoBehaviour
{
    public List<VLight> lights = new List<VLight>();
    public List<Color> colors = new List<Color>();

    private System.Random random = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateRandomLights", 0.0f, 2f);
        //GenerateRandomLights();
    }
    
    public void GenerateRandomLights()
    {
        foreach(VLight light in lights)
        { 
            int randomNumber = random.Next(0,colors.Count - 1);
            //Debug.Log(randomNumber);
            light.colorTint = colors[randomNumber];
            //Debug.Log(light.colorTint);
        }
    }

    //public void 
}
