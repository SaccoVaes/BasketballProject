using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginalBallLocation : MonoBehaviour
{
    private Transform originalTransform;
    private Vector3 originalPosition;

    private Rigidbody rb;
    // Start is called before the first frame update

    void Start()
    {
        originalTransform = this.transform;
        rb = this.gameObject.GetComponent<Rigidbody>();
        //Debug.Log(originalTransform);
        originalPosition = originalTransform.position;
    }

    public Vector3 GetOriginalTransformPosition()
    {
        return originalPosition;
    }

    public void SetKinematic(bool isKinematic)
    {
        Debug.Log(rb.isKinematic);
        rb.isKinematic = isKinematic;
        Debug.Log(rb.isKinematic);
    }
}
