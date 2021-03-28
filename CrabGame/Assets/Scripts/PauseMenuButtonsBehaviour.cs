using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtonsBehaviour : MonoBehaviour
{
    public void ShowPauseMenu()
    {
        gameObject.SetActive(true);
    }

    public void Resume()
    {
        gameObject.SetActive(false);
    }

    public void Restart()
    {
        StartCoroutine(LoadCurrentScene());
    }

    IEnumerator LoadCurrentScene()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        Scene scene = SceneManager.GetActiveScene();
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(scene.name);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void MainMenu()
    {
        StartCoroutine(LoadMainMenuScene());

    }

    IEnumerator LoadMainMenuScene()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Main Menu");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}