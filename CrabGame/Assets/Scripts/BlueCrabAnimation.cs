using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BlueCrabAnimation : MonoBehaviour
{
    public Animator blueCrabAnimator;


    // Start is called before the first frame update
    void Start()
    {
        transform.hasChanged = false;
    }

    //Update is called once per frame
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Crab2")
        {

            gameObject.GetComponent<NavMeshAgent>().SetDestination(gameObject.transform.position);


        }

    }

}
