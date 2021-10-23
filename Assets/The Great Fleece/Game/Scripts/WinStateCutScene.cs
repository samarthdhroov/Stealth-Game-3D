using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinStateCutScene : MonoBehaviour
{
    public GameObject winCutScene;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" )
        {
            if(GameManager.instance.hasCard == true)
            {
                winCutScene.SetActive(true);
            }
            else
            {
                Debug.Log("You Need the Key");
            }
            
        }
    }
}
