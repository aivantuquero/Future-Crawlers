using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
      
        
           transform.Rotate(0f, -90f*Time.deltaTime, 0f);
        

    }
}
