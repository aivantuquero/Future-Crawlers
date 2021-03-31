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
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level Selection C2");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void LoadLevelC1L1()
    {
        StartCoroutine(LoadLevel1());

    }

    IEnumerator LoadLevel1()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("C1 Level 1");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void LoadLevelC1L2()
    {
        StartCoroutine(LoadLevel2());

    }

    IEnumerator LoadLevel2()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("C1 Level 2");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void LoadLevelC1L3()
    {
        StartCoroutine(LoadLevel3());

    }

    IEnumerator LoadLevel3()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("C1 Level 3");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    public void LoadLevelC1L4()
    {
        StartCoroutine(LoadLevel4());

    }

    IEnumerator LoadLevel4()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("C1 Level 4");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void LoadLevelC1L5()
    {
        StartCoroutine(LoadLevel5());

    }

    IEnumerator LoadLevel5()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("C1 Level 5");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void LoadLevelC1L6()
    {
        StartCoroutine(LoadLevel6());

    }

    IEnumerator LoadLevel6()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("C1 Level 6");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void LoadLevelC1L7()
    {
        StartCoroutine(LoadLevel7());

    }

    IEnumerator LoadLevel7()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("C1 Level 7");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void LoadLevelC1L8()
    {
        StartCoroutine(LoadLevel8());

    }

    IEnumerator LoadLevel8()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("C1 Level 8");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }


}
