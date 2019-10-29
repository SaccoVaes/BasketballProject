using UnityEngine;
using System;

public class Publisher : MonoBehaviour
{
    //-- delegate --//
    public delegate void ButtonPressEventHandler(object source, EventArgs e);
    //-- event based on delegate --//
    public event ButtonPressEventHandler ButtonPressed;

    void Start()
    {
        //-- raise the event --//
        Debug.Log("Broadcasting button press event...");
        OnButtonPressed();
    }

    //-- event publisher (broadcaster) --//
    protected virtual void OnButtonPressed()
    {
        ButtonPressed(this, EventArgs.Empty);
    }
}