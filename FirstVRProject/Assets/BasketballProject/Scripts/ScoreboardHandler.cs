using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreboardHandler : MonoBehaviour
{
    //Singleton pattern.
    private static ScoreboardHandler Scoreboard = new ScoreboardHandler();

    public GameObject OnePointerLabel;
    public GameObject TwoPointerLabel;
    public GameObject ThreePointerLabel;
    public GameObject TotalScoreLabel;

    private int Onepointers, Twopointers, Threepointers;
    private TextMeshProUGUI TMP_Onepointers;
    private TextMeshProUGUI TMP_Twopointers;
    private TextMeshProUGUI TMP_Threepointers;
    private TextMeshProUGUI TMP_TotalScore;

    private void Start()
    {
        Scoreboard.TMP_Onepointers = OnePointerLabel.GetComponent<TMPro.TextMeshProUGUI>();
        Scoreboard.TMP_Twopointers = TwoPointerLabel.GetComponent<TMPro.TextMeshProUGUI>();
        Scoreboard.TMP_Threepointers = ThreePointerLabel.GetComponent<TMPro.TextMeshProUGUI>();
        Scoreboard.TMP_TotalScore = TotalScoreLabel.GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Private constructor om te voorkomen dat anderen een instantie kunnen aanmaken.
    private ScoreboardHandler()
    {
        //TMP_Onepointers = GameObject.Find("OnePointerCounterLabel").GetComponent<TMPro.TextMeshProUGUI>();
        /*/TMP_Onepointers = OnePointerLabel.GetComponent<TMPro.TextMeshProUGUI>();
        TMP_Twopointers = TwoPointerLabel.GetComponent<TMPro.TextMeshProUGUI>();
        TMP_Threepointers = ThreePointerLabel.GetComponent<TMPro.TextMeshProUGUI>();*/
    }  

    // Via een static read-only property kan de instantie benaderd worden.
    public static ScoreboardHandler Instance
    {
        get
        {
            return Scoreboard;
        }
    }


    public void AddOnePointer()
    {
        Onepointers++;
        TMP_Onepointers.text = Onepointers.ToString();
        UpdateTotalScore();
    }

    public void AddTwoPointer()
    {
        Twopointers++;
        TMP_Twopointers.text = Twopointers.ToString();
        UpdateTotalScore();
    }

    public void AddThreePointer()
    {
        Threepointers++;
        TMP_Threepointers.text = Threepointers.ToString();
        UpdateTotalScore();
    }

    public void UpdateTotalScore()
    {
        int totalscore;
        totalscore = Onepointers + (2 * Twopointers) + (3 * Threepointers);
        TMP_TotalScore.text = totalscore.ToString();
    }


}
