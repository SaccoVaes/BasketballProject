using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Ball")
        {
            return;
        }
        var script = other.gameObject.GetComponent<OriginalBallLocation>();
        var ball = other.gameObject;
        StartCoroutine(ResetBall(ball,script.GetOriginalTransformPosition()));

    }
    IEnumerator ResetBall(GameObject ball, Vector3 position)
    {
        yield return new WaitForSeconds(0.1f);
        //After 2 seconds... set object transform back to original position.
        ball.transform.position = position;
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
    }
}
