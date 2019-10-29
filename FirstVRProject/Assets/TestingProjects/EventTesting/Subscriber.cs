using UnityEngine;
using System;
public class Subscriber : MonoBehaviour   
{
    public Publisher publisher;
    void Start()
    {
    //-- subscribe to event --//
    publisher.ButtonPressed += OnButtonPressed;
    }

    //-- event listener method --//
    public void OnButtonPressed(object source, EventArgs e)
    {
        Debug.Log("Button press event registered!");
    }
}