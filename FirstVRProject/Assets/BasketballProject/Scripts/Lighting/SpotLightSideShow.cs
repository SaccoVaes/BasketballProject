using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightSideShow : MonoBehaviour
{
    public List<VLight> lights = new List<VLight>();
    public Color ColorOff;
    public Color ColorOn;

    private bool IsFlickeringEnabled;

    public void FlickerLights()
    {
        if (IsFlickeringEnabled)
        {
            foreach (VLight light in lights)
            {
                light.colorTint = ColorOn;
                StartCoroutine("DisableLights", light);
            }
        }
    }

    public IEnumerator DisableLights(VLight light)
    {
        yield return new WaitForSeconds(0.01f);
        light.colorTint = ColorOff;
    }

    public IEnumerator EnableFlickering()
    {
        IsFlickeringEnabled = true;
        yield return new WaitForSeconds(2);
        IsFlickeringEnabled = false;
    }
}
