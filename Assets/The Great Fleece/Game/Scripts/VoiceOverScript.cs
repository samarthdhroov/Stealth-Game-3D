using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceOverScript : MonoBehaviour
{
    public AudioClip clip;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            AudioManager.Instance.playVoiceOverTrack(clip);
        }
    }

}

