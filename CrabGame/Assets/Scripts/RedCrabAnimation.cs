using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Crab1")
        {
            gameObject.GetComponent<NavMeshAgent>().SetDestination(gameObject.transform.position);


        }

    }
}
