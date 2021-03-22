using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCrabAnimation : MonoBehaviour
{
    public Animator blueCrabAnimator;
    // Start is called before the first frame update
    void Start()
    {
        transform.hasChanged = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.hasChanged)
        {
            blueCrabAnimator.Play("WalkingBlue");
            transform.hasChanged = false;
        }
        else
        {
            blueCrabAnimator.Play("IdleBlue");
        }


    }
}
