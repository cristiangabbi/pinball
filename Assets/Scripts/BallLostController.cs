using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class BallLostController : MonoBehaviour
{
    public GameController gameController;
    public string collisionTag;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag(collisionTag))
        {
            //update game Controller
            gameController.UpdateLife();
        }
    }
}
