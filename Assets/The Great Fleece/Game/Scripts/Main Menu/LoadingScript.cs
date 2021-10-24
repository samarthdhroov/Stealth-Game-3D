using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScript : MonoBehaviour
{

    public Image LoadingBar;

    public void Start()
    {
        StartCoroutine(LoadSceneAsync());
    }

    IEnumerator LoadSceneAsync()
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("Main");

        while (!asyncOperation.isDone)
        {
            LoadingBar.fillAmount = asyncOperation.progress;
            yield return new WaitForEndOfFrame();
        }
       
    }
}
