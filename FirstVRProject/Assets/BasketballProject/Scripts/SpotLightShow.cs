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
        InvokeRepeating("GenerateRandomLights", 0.0f, 3f);
        //GenerateRandomLights();
    }
    
    public void GenerateRandomLights()
    {
        foreach(VLight light in lights)
        { 
            int randomNumber = random.Next(0,colors.Count - 1);
            //Color nextColor = colors[randomNumber];
            //light.colorTint = Color.Lerp(light.colorTint, nextColor, 0.1f);
            
            light.colorTint = colors[randomNumber];
        }
    }

    public void FlickerLights()
    {
        foreach (VLight light in lights)
        {
            //light.enabled = false;

            Debug.Log("Flicker enabled ");
            Invoke("LightScript(light)", 0.01f);
        }
    }

    //Make Ienumerator for this.
    public void LightScript(VLight script)
    {
        //script.enabled = true;
        Debug.Log("Flicker disabled ");
    }
}
