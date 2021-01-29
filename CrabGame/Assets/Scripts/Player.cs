using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public LayerMask whatCanBeClickedOn;
    public GameObject stackbutton;

    private NavMeshAgent currentCrab;
    private Player otherCrabControl;
    private string otherCrabName;
    private bool stack = false;

    // Binded to StackButton button 
    public void Stack()
    {
        stack = !stack;
    }

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
        // Check if crabs are near each other
        if ((transform.position - otherCrabControl.transform.position).magnitude < 2f)
        {
            // Enable button when crabs are near each other
            stackbutton.SetActive(true);
            // Check if stack button is clicked
            if (stack)
            {
                // Code here to stack crabs
            }
        }
        else
        {
            // Disable button when crabs are far away from each other
            stackbutton.SetActive(false);
        }

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
