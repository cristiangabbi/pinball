using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text scoreText;
    public Text lifeText;


    public void SetScore(int score)
    {
        if(scoreText != null)
            scoreText.text = score.ToString();
    }

    public void SetLife(int life)
    {
        if(lifeText != null)
            lifeText.text = life.ToString();
    }

    public int GetLife()
    {
        return int.Parse(lifeText.text);
    }
}
