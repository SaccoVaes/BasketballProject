using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginalBallLocation : MonoBehaviour
{
    private Transform originalTransform;
    private Vector3 originalPosition;
    // Start is called before the first frame update

    void Start()
    {
        //Voor ball v1
        //originalTransform = this.transform.parent;
        originalTransform = this.transform;

        //Debug.Log(originalTransform);
        originalPosition = originalTransform.position;
        //Debug.Log(originalPosition);
    }

    public Vector3 GetOriginalTransformPosition()
    {
        return originalPosition;
    }
}
