using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{

    //Detection code for ending the level
    private int nextSceneLoad;
    private bool isCollidedWithCrab1 = false;
    private bool isCollidedWithCrab2 = false;
    public SuccessPanelBehaviour SuccessPanel;

    private void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Crab1")
        {
            isCollidedWithCrab1 = true;
        }
        else if (collider.gameObject.name == "Crab2")
        {
            isCollidedWithCrab2 = true;

        }
        //both of the crabs must be inside to continue
        if (isCollidedWithCrab1 && isCollidedWithCrab2)
        {

            //this code will cause some errors if the last level is surpassed as per https://youtu.be/vpbPd6jNEBs
            //but since the last level is made to be impossible to finish, it should not be a problem.

            SuccessPanel.ShowSuccessMenu();
            if(nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }
        }

    }

}
