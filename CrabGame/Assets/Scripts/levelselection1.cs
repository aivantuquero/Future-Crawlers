using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelselection1 : MonoBehaviour
{
    public void BackButton()
    {
        StartCoroutine(LoadMainMenu());

    }

    IEnumerator LoadMainMenu()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Main menu");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    public void NextButton()
    {
        StartCoroutine(LoadChapter2());

    }

    IEnumerator LoadChapter2()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Chapter2.ls");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }


}
