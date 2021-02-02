using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public LayerMask whatCanBeClickedOn;

    private NavMeshAgent currentCrab;
    private Player otherCrabControl;
    private string otherCrabName;

    private void Start()
    {
        // Look for other crab
        if (name == "Crab1")
        {
            otherCrabName = "Crab2";
        }
        else
        {
            otherCrabName = "Crab1";
        }
        otherCrabControl = GameObject.Find(otherCrabName).GetComponent<Player>();
    }

    private void OnMouseDown()
    {
        currentCrab = GetComponent<NavMeshAgent>();  
        otherCrabControl.currentCrab = null;
    }

    private void Update()
    {
        //player movement 
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
