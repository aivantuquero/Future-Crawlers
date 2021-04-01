using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelselection1 : MonoBehaviour
{

    private bool loadScene = false;
    public Text loadingText;
    public Slider sliderBar;
    public Image loadingScreenPanel;

    private void Start()
    {
        sliderBar.gameObject.SetActive(false);
    }


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
        
        
        // ...set the loadScene boolean to true to prevent loading a new scene more than once...
        loadScene = true;

        //Visible Slider Progress bar
        sliderBar.gameObject.SetActive(true);

        // ...change the instruction text to read "Loading..."
        loadingText.text = "Loading...";

        loadingScreenPanel.gameObject.SetActive(true);

        // ...and start a coroutine that will load the desired scene.
        StartCoroutine(LoadLevel1());

    }

    IEnumerator LoadLevel1()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("C1 Level 1");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);
            sliderBar.value = progress;
         
            yield return null;
        }
    }

    public void LoadLevelC1L2()
    {
        // ...set the loadScene boolean to true to prevent loading a new scene more than once...
        loadScene = true;

        //Visible Slider Progress bar
        sliderBar.gameObject.SetActive(true);

        // ...change the instruction text to read "Loading..."
        loadingText.text = "Loading...";

        loadingScreenPanel.gameObject.SetActive(true);
        StartCoroutine(LoadLevel2());

    }

    IEnumerator LoadLevel2()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("C1 Level 2");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);
            sliderBar.value = progress;
           
            yield return null;
        }
    }

    public void LoadLevelC1L3()
    {
        // ...set the loadScene boolean to true to prevent loading a new scene more than once...
        loadScene = true;

        //Visible Slider Progress bar
        sliderBar.gameObject.SetActive(true);

        // ...change the instruction text to read "Loading..."
        loadingText.text = "Loading...";

        loadingScreenPanel.gameObject.SetActive(true);
        StartCoroutine(LoadLevel3());

    }

    IEnumerator LoadLevel3()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("C1 Level 3");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);
            sliderBar.value = progress;
           
            yield return null;
        }
    }
    public void LoadLevelC1L4()
    {
        // ...set the loadScene boolean to true to prevent loading a new scene more than once...
        loadScene = true;

        //Visible Slider Progress bar
        sliderBar.gameObject.SetActive(true);

        // ...change the instruction text to read "Loading..."
        loadingText.text = "Loading...";

        loadingScreenPanel.gameObject.SetActive(true);
        StartCoroutine(LoadLevel4());

    }

    IEnumerator LoadLevel4()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("C1 Level 4");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);
            sliderBar.value = progress;
          
            yield return null;
        }
    }

    public void LoadLevelC1L5()
    {
        // ...set the loadScene boolean to true to prevent loading a new scene more than once...
        loadScene = true;

        //Visible Slider Progress bar
        sliderBar.gameObject.SetActive(true);

        // ...change the instruction text to read "Loading..."
        loadingText.text = "Loading...";

        loadingScreenPanel.gameObject.SetActive(true);
        StartCoroutine(LoadLevel5());

    }

    IEnumerator LoadLevel5()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("C1 Level 5");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);
            sliderBar.value = progress;
            
            yield return null;
        }
    }

    public void LoadLevelC1L6()
    {
        // ...set the loadScene boolean to true to prevent loading a new scene more than once...
        loadScene = true;

        //Visible Slider Progress bar
        sliderBar.gameObject.SetActive(true);

        // ...change the instruction text to read "Loading..."
        loadingText.text = "Loading...";

        loadingScreenPanel.gameObject.SetActive(true);
        StartCoroutine(LoadLevel6());

    }

    IEnumerator LoadLevel6()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("C1 Level 6");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);
            sliderBar.value = progress;
           
            yield return null;
        }
    }

    public void LoadLevelC1L7()
    {
        // ...set the loadScene boolean to true to prevent loading a new scene more than once...
        loadScene = true;

        //Visible Slider Progress bar
        sliderBar.gameObject.SetActive(true);

        // ...change the instruction text to read "Loading..."
        loadingText.text = "Loading...";

        loadingScreenPanel.gameObject.SetActive(true);
        StartCoroutine(LoadLevel7());

    }

    IEnumerator LoadLevel7()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("C1 Level 7");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);
            sliderBar.value = progress;
          
            yield return null;
        }
    }

    public void LoadLevelC1L8()
    {
        // ...set the loadScene boolean to true to prevent loading a new scene more than once...
        loadScene = true;

        //Visible Slider Progress bar
        sliderBar.gameObject.SetActive(true);

        // ...change the instruction text to read "Loading..."
        loadingText.text = "Loading...";

        loadingScreenPanel.gameObject.SetActive(true);
        StartCoroutine(LoadLevel8());

    }

    IEnumerator LoadLevel8()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("C1 Level 8");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);
            sliderBar.value = progress;
            yield return null;
        }
    }


}
