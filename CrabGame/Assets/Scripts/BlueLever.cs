using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BlueLever : MonoBehaviour
{
    public GameObject crab;
    public Button button;

    private int requireLeverActivationDistance = 5;

    private bool isSwitched = false;
    private bool flipped = false;
    private float minLeverAngle = 0.4f;
    private float maxLeverAngle = 0.9f;

    
    void Update()
    {
        // Enable lever button if distance of crab and lever = requireLeverActivationDistance
        if (Vector3.Distance(gameObject.transform.position,
                            crab.transform.position)         // Lines too long, did this for readability
                            < requireLeverActivationDistance)
        {
            button.gameObject.SetActive(true);
        }
        else
        {
            button.gameObject.SetActive(false);
        }

        // Hard-coded animation for lever
        if (flipped)
        {
            GameObject leverHandle = this.gameObject.transform.GetChild(1).gameObject;
            float degreeStep = 50f;
            float step = degreeStep * Time.deltaTime;

            if (isSwitched)
            {
                
                if (leverHandle.transform.rotation.x < maxLeverAngle)
                {
                    leverHandle.transform.Rotate(Vector3.right, step);
                }
                else
                {
                    flipped = false;
                }
            }
            else
            {
                if (leverHandle.transform.rotation.x > minLeverAngle)
                {
                    leverHandle.transform.Rotate(Vector3.left, step);
                }
                else
                {
                    flipped = false;
                }
            }
        }
    }

    public void BlueSwitchOn()
    {
        flipped = true;
        isSwitched = !isSwitched;
    }
}