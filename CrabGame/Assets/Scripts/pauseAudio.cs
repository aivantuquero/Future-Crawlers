using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   //this code will stop the background audio from playing.
        BGsoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
        
    }
}
