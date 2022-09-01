using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour
{
    public GameObject ballObj;

    public void RespawnBall()
    {
        //instead of instantiating a new ball, we just reposition the old one
        ballObj.SetActive(true);
        ballObj.transform.position = transform.position;
    }
}
