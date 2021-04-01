using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playaudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BGsoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
