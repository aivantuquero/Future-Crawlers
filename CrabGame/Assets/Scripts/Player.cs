using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
                        
public class Player : MonoBehaviour
{
    public LayerMask whatCanBeClickedOn;

    private NavMeshAgent myAgent;

    private void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        //player movement kinopya ko lang itong code sa https://www.youtube.com/watch?v=KU2CKBlCAxQ
        if (Input.GetMouseButtonDown(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            
            if(Physics.Raycast(myRay, out hitInfo, 100, whatCanBeClickedOn))
            {
                myAgent.SetDestination(hitInfo.point);
            }
        }
    }
}
