using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
                        
public class Player : MonoBehaviour
{
    public LayerMask whatCanBeClickedOn;

    private NavMeshAgent currentCrab;

    private void OnMouseDown()
    {
        // myAgent changed to currentCrab
        currentCrab = GetComponent<NavMeshAgent>();
        // If we select a crab, define currentCrab as its NavMesh agent and
        // change the other crab's currentCrab to null so it doesn't move
        string otherCrabName = name == "Crab1" ? "Crab2" : "Crab1";
        GameObject.Find(otherCrabName).GetComponent<Player>().currentCrab = null;
    }

    private void Update()
    {
        //player movement kinopya ko lang itong code sa https://www.youtube.com/watch?v=KU2CKBlCAxQ
        if (Input.GetMouseButtonDown(0) && currentCrab != null)
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            
            if(Physics.Raycast(myRay, out hitInfo, 100, whatCanBeClickedOn))
            {
                currentCrab.SetDestination(hitInfo.point);
            }
        }
    }
}
