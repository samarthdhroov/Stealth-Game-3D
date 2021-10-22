using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityCamera : MonoBehaviour
{

    public GameObject gameOverCutScene;

    Animator cameraAnim;

    Renderer CamRenderer;


    private void Start()
    {
        cameraAnim = GetComponentInParent<Animator>();
        CamRenderer = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            cameraAnim.enabled = false;
            Color redcolor = new Color(0.6f, 0.1f, 0.1f, 0.3f); // Original Value of Color is (154,29,29,10). However, itd be a white color when played with this config. So, we changed to its decimal values.
            CamRenderer.material.SetColor("_TintColor", redcolor);
            StartCoroutine(cameraHalt());
        }
    }

    IEnumerator cameraHalt()
    {
        yield return new WaitForSeconds(0.5f);
        gameOverCutScene.SetActive(true);
    }
}
