using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandlerScript : MonoBehaviour
{
    public GridManager gridmanager;
    public InputField input1;
    public InputField input2;

    public void OnButtonClick()
    {
        int getal;
        bool result = int.TryParse(input1.text, out getal);
        if (!result)
            return; //something has gone wrong
                    //OK, continue using val

        //int font = int.Parse(input2.text);

        StartCoroutine(gridmanager.DrawNumbers(getal, getal));

    }

}
