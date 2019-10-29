using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public float x_Start, y_Start;
    public float x_Space, y_Space;
    public GameObject prefab;
    private int counter = 1;

    public IEnumerator DrawNumbers(int columnLength, int rowLength)
    {
        //How many numbers should be drawn?
        int target = columnLength - 1;
        //How many times did the round get completed?
        int completedRounds = 0;

        while (counter <= columnLength * rowLength)
        {
            yield return new WaitForSeconds(0.5f);
            //Right Direction Move  
            for (int i = completedRounds; i <= target; i++) //Input 5 = 5x loopen.
            {
                GameObject g = Instantiate(prefab, new Vector3(x_Start + (x_Space * i), y_Start - completedRounds * y_Space), Quaternion.identity, GameObject.Find("Panel").transform);
                g.GetComponent<UnityEngine.UI.Text>().text = counter.ToString();
                counter++;
                yield return new WaitForSeconds(0.1f);
            }
            
            //Down Direction Move  
            for (int j = completedRounds + 1; j <= target; j++)
            {
                GameObject g = Instantiate(prefab, new Vector3(x_Start + (x_Space * target), y_Start + (j * -y_Space)), Quaternion.identity, GameObject.Find("Panel").transform);
                g.GetComponent<UnityEngine.UI.Text>().text = counter.ToString();
                counter++;
                yield return new WaitForSeconds(0.1f);
            }

            //Left Direction Move  
            for (int i = target - 1; i >= completedRounds; i--)
            {
                GameObject g = Instantiate(prefab, new Vector3(x_Start + (x_Space * i), y_Start + (-y_Space * target)), Quaternion.identity, GameObject.Find("Panel").transform);
                g.GetComponent<UnityEngine.UI.Text>().text = counter.ToString();
                counter++;
                yield return new WaitForSeconds(0.1f);
            }

            //Up Direction Move  
            for (int j = target - 1; j >= completedRounds + 1; j--)
            {
                GameObject g = Instantiate(prefab, new Vector3(x_Start + (completedRounds * x_Space), y_Start + (j * -y_Space)), Quaternion.identity, GameObject.Find("Panel").transform);
                g.GetComponent<UnityEngine.UI.Text>().text = counter.ToString();
                counter++;
                yield return new WaitForSeconds(0.1f);
            }
    
            target -= 1;
            completedRounds++;
        }
    }
}
