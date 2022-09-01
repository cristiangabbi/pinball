using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HingeJoint))]
public class BarController : MonoBehaviour
{
    public float minAngle;
    public float maxAngle;
    public float rotationStrenght = 1000f;
    public float damper = 100f;
    public KeyCode activationKey;

    HingeJoint hinge;
    JointSpring spring;

    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;

        //setting spring component
        spring = new JointSpring();
        spring.damper = damper;
        spring.spring = rotationStrenght;
    }

    private void Update()
    {

        if (Input.GetKey(activationKey))
        {
            spring.targetPosition = - maxAngle;
        }
        else
        {
            spring.targetPosition = minAngle;
        }

        hinge.spring = spring;
        hinge.useLimits = true;
    }

}
