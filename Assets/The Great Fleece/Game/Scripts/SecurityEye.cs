using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityEye : MonoBehaviour
{


    public GameObject gameOverScene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameOverScene.SetActive(true);
        }
    }
}
