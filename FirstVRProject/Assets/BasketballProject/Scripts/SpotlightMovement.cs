using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightMovement : MonoBehaviour
{
    public List<Vector3> locations = new List<Vector3>();
    public GameObject SpotlightParent;
    public GameObject SpotlightChild;

    private Quaternion toRotationParent;
    private Quaternion toRotationChild;
    //How fast should it rotate?

    // Start is called before the first frame update
    void Start()
    {

        GenerateNewRotations();
    }

    // Update is called once per frame
    void Update()
    {
        //While rotation is not completed yet...
        if(SpotlightParent.transform.rotation != toRotationParent)
        {
            //Move parent along y-axes
            SpotlightParent.transform.localRotation = Quaternion.RotateTowards(SpotlightParent.transform.localRotation, toRotationParent, Time.deltaTime * 20);
            //SpotlightParent.transform.rotation = Quaternion.RotateTowards(SpotlightParent.transform.rotation, toRotationParent, Time.time * speedParent);
            
            //Move child along x-axes
            SpotlightChild.transform.localRotation = Quaternion.RotateTowards(SpotlightChild.transform.localRotation, toRotationChild, Time.deltaTime * 20);
            //SpotlightChild.transform.rotation = Quaternion.RotateTowards(SpotlightChild.transform.rotation, toRotationChild, Time.time * speedChild);
        }
        //Else if the rotation has been completed...
        else
        {
            GenerateNewRotations();
        }
        
    }

    public void GenerateNewRotations()
    {
        int index = Random.Range(0, locations.Count - 1);
        Vector3 v = locations[index];
        Quaternion parentQuaternion = Quaternion.Euler(new Vector3(0,v.x,0));
        Quaternion childQuaternion = Quaternion.Euler(new Vector3(v.y,0,0));
        toRotationParent = parentQuaternion;
        toRotationChild = childQuaternion;
    }
}
