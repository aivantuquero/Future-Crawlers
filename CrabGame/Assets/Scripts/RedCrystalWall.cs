using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RedCrystalWall : MonoBehaviour
{
    public bool isActivated = false;
    
    //the navmesh obstacle attached to the gameobject
    public NavMeshObstacle nmo2;

    void Update()
    {
        //If the lever is activated, the wall will move down by a factor of -2
        if (isActivated == true && transform.position.y > 2)
        {
            Vector3 currentPosition;
            currentPosition = transform.position;
            currentPosition.y += -2 * Time.deltaTime;
            transform.position = currentPosition;


        }

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Crab2")
        {
            //disable the navmeshobstacle when crab2 is detected
            nmo2.enabled = false;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Crab2")
        {
            nmo2.enabled = true;
        }
    }
}
