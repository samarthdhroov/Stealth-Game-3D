using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    public PlayableDirector IntroCutScenePlayableDirector;

    public static GameManager instance
    {
        get
        {
            return _instance;

            if(_instance == null)
            {
                Debug.LogError("Empty Game Manager");
            }
        }

    }

    public bool hasCard { get; set; }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            IntroCutScenePlayableDirector.time = 59.05f;
            AudioManager.Instance.BackgroundMusic.volume = 0.3f;
            AudioManager.Instance.playBackgroundMusic();
        }
    }

    private void Awake()
    {
        _instance = this;
    }
}
