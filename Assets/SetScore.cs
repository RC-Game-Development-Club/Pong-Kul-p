using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetScore : MonoBehaviour
{
    public TextMeshProUGUI textMeshProBlue;
    public TextMeshProUGUI textMeshProRed;

    void Update()
    {
        GameObject scoreRed = GameObject.FindGameObjectWithTag("RedScore");
        int redScore = scoreRed.GetComponent<LoseBlue>().redScore;
        textMeshProRed.text = "Score: " + redScore;

        GameObject scoreBlue = GameObject.FindGameObjectWithTag("BlueScore");
        int blueScore = scoreBlue.GetComponent<LoseRed>().blueScore;
        textMeshProBlue.text = "Score: " + blueScore;

    }
}
