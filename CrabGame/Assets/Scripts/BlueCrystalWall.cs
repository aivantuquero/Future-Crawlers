using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BlueCrystalWall : MonoBehaviour
{
    public bool isActivated = false;
    private bool hasPlayed = false;
    public AudioSource wallSound;
    
    //the navmesh obstacle attached to the gameobject
    public NavMeshObstacle nmo;

    void Update()
    {
        //If the lever is activated, the wall will move down by a factor of -2
        if (isActivated == true && transform.position.y > 2)
        {
            if (!hasPlayed)
            {
                wallSound.Play();
                hasPlayed = true;
            
            }
            Vector3 currentPosition;
            currentPosition = transform.position;
            currentPosition.y += -2 * Time.deltaTime;
            transform.position = currentPosition;

        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Crab1")
        {
            //disable the navmeshobstacle when crab1 is detected
            nmo.enabled = false;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Crab1")
        {
            nmo.enabled = true;
        }
    }
}
