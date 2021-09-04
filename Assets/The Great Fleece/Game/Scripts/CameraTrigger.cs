using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public GameObject cameras;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Camera.main.transform.position = cameras.transform.position;
            Camera.main.transform.rotation = cameras.transform.rotation;
        }
    }
}
