using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    private static UiManager _instance;

    public static UiManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("UI Manager Empty.");
            }

            return _instance;
        }
    }


    private void Awake()
    {
        _instance = this;
    }


    public void restart()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
