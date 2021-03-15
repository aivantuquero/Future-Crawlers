using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    
    //Detection code for ending the level
    private bool isCollidedWithCrab1 = false;
    private bool isCollidedWithCrab2 = false;
    
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Crab1")
        {
            isCollidedWithCrab1 = true;
        }
        else if (collider.gameObject.name == "Crab2")
        {
            isCollidedWithCrab2 = true;

        }
        //both of the crabs must be inside to continue
        if (isCollidedWithCrab1 && isCollidedWithCrab2)
        {
            Debug.Log("Both of the crabs are detected, proceed to the next level");
            //gotta insert some more codes here in the future
        }

    }

}
