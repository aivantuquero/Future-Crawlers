using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCrabAnimation : MonoBehaviour
{

    public Animator redCrabAnimator;
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
            redCrabAnimator.Play("RedWalking");
            transform.hasChanged = false;
        }
        else
        {
            redCrabAnimator.Play("RedIdle");
        }


    }
}
