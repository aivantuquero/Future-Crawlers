using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelselection2 : MonoBehaviour
{
    public void BackButton()
    {
        StartCoroutine(LoadChapter1());

    }

    IEnumerator LoadChapter1()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level Selection C1");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    


}
