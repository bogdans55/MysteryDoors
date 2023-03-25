using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpdateScore : MonoBehaviour
{
    public void CorrectAnswer()
    {
        ScoreManager.score += 10;
        if(ScoreManager.score >= 40)
            SceneManager.LoadScene("win");
    }

    public void WrongAnswer()
    {
        ScoreManager.hp--;
        if(ScoreManager.hp <= 0)
            SceneManager.LoadScene("lose");
    }
}
