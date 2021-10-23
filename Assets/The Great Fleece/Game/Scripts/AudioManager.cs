using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance;

    public AudioSource VoiceOverAudioSource;

    public AudioSource BackgroundMusic;

    public static AudioManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("Audio Manager Empty");
            }

            return _instance;
        }
    }

    public void playVoiceOverTrack(AudioClip clipToPlay)
    {
        VoiceOverAudioSource.clip = clipToPlay;
        VoiceOverAudioSource.Play();
    }

    public void playBackgroundMusic()
    {
        BackgroundMusic.Play();
    }
    private void Awake()
    {
        _instance = this;
    }
}
