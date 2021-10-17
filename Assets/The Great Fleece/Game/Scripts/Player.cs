using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    NavMeshAgent agent;
    Vector3 target;
   

    private void Start()
    {
       agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        // Checking for a left-click

        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray from mouse position

            Ray myFirstRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;

            

            if (Physics.Raycast(myFirstRay,out hitInfo)) //Bool returns true if there is collision.
            {
                //Debug the floor position hit

                // Debug.Log("Hit : " + hitInfo.point);

                // Create object at floor position

                /* GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                 cube.transform.position = hitInfo.point;*/

                // transform.position = hitInfo.point;

                agent.SetDestination(hitInfo.point); //This basically changes the position after movement whereas the transform.position does not. Swap the line above to understand it.

                target = hitInfo.point;

                GetComponentInChildren<Animator>().SetBool("Walk",true);

            }

        }

        float distance = Vector3.Distance(transform.position, target);
        if (distance < 2.0f)
        {
            GetComponentInChildren<Animator>().SetBool("Walk", false);
        }


    }

}
