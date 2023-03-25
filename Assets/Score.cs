using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        scoreText.text = "Score: " + ScoreManager.score.ToString() + '\n' + "HP: " + ScoreManager.hp.ToString();
    }
}
