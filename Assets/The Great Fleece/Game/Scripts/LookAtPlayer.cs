using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform player;
    public GameObject startCamera;


    private void Start()
    {
        transform.position = startCamera.transform.position;
        transform.rotation = startCamera.transform.rotation;
    }


    void Update()
    {
        transform.LookAt(player);
    }
}
