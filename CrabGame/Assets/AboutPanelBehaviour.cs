using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutPanelBehaviour : MonoBehaviour
{
 

    public void exitAboutPanel()
    {
        gameObject.SetActive(false);
    }
    public void openAboutPanel()
    {
        gameObject.SetActive(true);
    }
}
