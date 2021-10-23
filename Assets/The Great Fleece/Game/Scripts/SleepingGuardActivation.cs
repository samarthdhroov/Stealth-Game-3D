using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepingGuardActivation : MonoBehaviour
{
    public GameObject sleepingGuardCutScene;
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            sleepingGuardCutScene.SetActive(true);
            GameManager.instance.hasCard = true;
            GetComponent<Collider>().enabled = false;
        }
    }
}
