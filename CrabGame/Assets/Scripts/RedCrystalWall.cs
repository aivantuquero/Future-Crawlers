using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCrystalWall : MonoBehaviour
{
    public bool isActivated = false;

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
}
