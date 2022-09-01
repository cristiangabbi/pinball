using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public UIController controllerUI;
    public RespawnController controllerRespawn;

    private int lifeNumber = 3;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //initializes controller
        if(controllerUI != null)
        {
            controllerUI.SetLife(lifeNumber);
            controllerUI.SetScore(0);
        }
        if(controllerRespawn != null)
        {
            controllerRespawn.RespawnBall();
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;

        //update UI
        controllerUI.SetScore(score);
    }

    public void UpdateLife()
    {
        //reduce life count
        lifeNumber--;

        //update UI
        controllerUI.SetLife(lifeNumber);

        //game over check
        isGameOver();
    }


    private void isGameOver()
    {
        if(lifeNumber == 0)
        {
            //game over
        }
        else
        {
            //respawn ball
            controllerRespawn.RespawnBall();
        }
    }
}
