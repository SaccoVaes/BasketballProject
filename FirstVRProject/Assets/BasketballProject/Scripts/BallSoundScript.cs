using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSoundScript : MonoBehaviour
{
    public AudioSource Audio;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 12)
        {
            Audio.Play();
        }
        
    }
}
