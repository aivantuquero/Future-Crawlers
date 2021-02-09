using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRotator : MonoBehaviour
{

    //The swipe rotation only works on touch devices, so dapat idebug mo sya sa unity app sa smartphone mo. download mo to https://play.google.com/store/apps/details?id=com.unity3d.mobileremote

    private Touch touch;
    private Vector2 touchPosition;
    private Quaternion rotationY;

    //rotation speed modifier
    private float rotateSpeedModifier = 0.1f;


    void Update()
    {
        //this condition gets activated when you touched a screen (only works on touch devices)
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            //this condition gets activated when it detects a movement on your touch
            if(touch.phase == TouchPhase.Moved)
            {
                //read more about quartenion euler here https://docs.unity3d.com/ScriptReference/Quaternion.Euler.html
                rotationY = Quaternion.Euler(0f, -touch.deltaPosition.x * rotateSpeedModifier, 0f);
                transform.rotation = rotationY * transform.rotation;

            }
        }
        

    }
}
