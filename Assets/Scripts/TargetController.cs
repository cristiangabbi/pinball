using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public GameController controllerGame;
    public string ballTag;
    public int score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(ballTag))
        {
            controllerGame.UpdateScore(score);

            //delete this target
            Destroy(gameObject);
        }

    }
}
