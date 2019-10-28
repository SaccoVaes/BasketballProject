using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RackEnabler : MonoBehaviour
{
    public GameObject basketballrackPrefab;
    public int ScoreMultiplier;
    private GameObject[] racks;
    
    public void InstantiateRack()
    {
        racks = GameObject.FindGameObjectsWithTag("Rack");
        foreach(GameObject r in racks)
        {
            Destroy(r);
        }

        Instantiate(basketballrackPrefab);
        ScoreboardHandler.Instance.multiplier = ScoreMultiplier;
       
    }

}