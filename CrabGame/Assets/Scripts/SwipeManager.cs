using UnityEngine;

public class SwipeManager : MonoBehaviour
{

    public Transform ToRotate;
    // We can add an invisible gameobject at the center of the platform which ToRotate (camera) rotates around
    public Transform RotationCenterPoint;
    private Touch startTouch;
    private bool dragging = false;

    private void Update()
    {
        // Check for touches
        if (Input.touchCount > 0)
        {
            // Get start position
            if (!dragging)
            {
                startTouch = Input.GetTouch(0);
                dragging = true;
            }
            else
            {
                // If dragging, compare startTouch to current touch and decide what direction to turn
                if(startTouch.position.magnitude > Input.GetTouch(0).position.magnitude)
                {
                    ToRotate.RotateAround(RotationCenterPoint.position, Vector3.up, 30 * Time.deltaTime);
                }
                else if(startTouch.position.magnitude < Input.GetTouch(0).position.magnitude)
                {
                    ToRotate.RotateAround(RotationCenterPoint.position, Vector3.down, 30 * Time.deltaTime);
                }
            }
        } 
        // If not touching, dragging is false
        else
        {
            dragging = false;
        }
    }
}