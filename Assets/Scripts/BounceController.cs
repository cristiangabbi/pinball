using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceController : MonoBehaviour
{
    public float bounceStrength = 1f;

    private void OnCollisionStay(Collision collision)
    {
        foreach (var contactPoint in collision.contacts)
        {
            collision.rigidbody.AddForce(-contactPoint.normal * bounceStrength, ForceMode.Impulse);
        }
    }

}
