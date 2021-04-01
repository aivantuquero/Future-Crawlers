using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuccessPanelBehaviour : MonoBehaviour
{
    public void ShowSuccessMenu()
    {
        gameObject.SetActive(true);
    }

    public void RestartLevel()
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

    public void LevelSelect()
    {
        StartCoroutine(LoadMainMenuScene());

    }

    IEnumerator LoadMainMenuScene()
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
