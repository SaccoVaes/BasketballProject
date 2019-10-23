using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightMovement : MonoBehaviour
{
    public GameObject SpotlightParent;
    public GameObject SpotlightChild;

    private Quaternion toRotationParent;
    private Quaternion toRotationChild;
    private float parentTransform;
    private float childTransform;

    // Start is called before the first frame update
    void Start()
    {
        parentTransform = SpotlightParent.transform.localEulerAngles.y;
        childTransform = SpotlightChild.transform.localEulerAngles.x;
        GenerateNewRotations();
    }

    // Update is called once per frame
    void Update()
    {
        //While rotation is not completed yet...
        if(SpotlightParent.transform.rotation != toRotationParent)
        {
            //Move parent along y-axes
            SpotlightParent.transform.localRotation = Quaternion.RotateTowards(SpotlightParent.transform.localRotation, toRotationParent, Time.deltaTime * 15);
            //SpotlightParent.transform.rotation = Quaternion.RotateTowards(SpotlightParent.transform.rotation, toRotationParent, Time.time * speedParent);
            
            //Move child along x-axes
            SpotlightChild.transform.localRotation = Quaternion.RotateTowards(SpotlightChild.transform.localRotation, toRotationChild, Time.deltaTime * 15);
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
        float y = Random.Range(parentTransform - 20.0f, parentTransform + 20.0f);
        float x = Random.Range(childTransform - 15.0f, childTransform + 15.0f);
        //Quaternion parentQuaternion = Quaternion.Euler(new Vector3(0,v.x,0));
        Quaternion parentQuaternion = Quaternion.Euler(new Vector3(0, y, 0));
        //Quaternion childQuaternion = Quaternion.Euler(new Vector3(v.y,0,0));
        Quaternion childQuaternion = Quaternion.Euler(new Vector3(x, 0, 0));
        toRotationParent = parentQuaternion;
        toRotationChild = childQuaternion;
    }
}
