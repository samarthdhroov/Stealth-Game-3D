using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardAI : MonoBehaviour
{
    public List<Transform> waypoints = new List<Transform>();
    NavMeshAgent agent;
    Animator animatorComponent;
    public int currentPosition;
    float distance;
    bool reverse;
    bool targetPositionReached = false;
  
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animatorComponent = GetComponent<Animator>();
    }

    void Update()
    {
      if (waypoints.Count > 0 && waypoints[currentPosition] != null)
        {
            agent.SetDestination(waypoints[currentPosition].position);

            distance = Vector3.Distance(transform.position, waypoints[currentPosition].position);


            if (distance < 0.5f && targetPositionReached == false)
            {

                if (waypoints.Count < 2)
                {
                    animatorComponent.SetBool("Walk", false);
                    return;
                }
               
                targetPositionReached = true;
                StartCoroutine(waitBeforeGoingToTheNextPosition());
            }

            // Animator component controller below.
            
            if (distance < 0.5f)
            {
                if(animatorComponent != null)
                {
                    animatorComponent.SetBool("Walk", false);
                }
            }
            else
            {
                if (animatorComponent != null)
                {
                    animatorComponent.SetBool("Walk", true);
                }
            }
        }
        
    }

    IEnumerator waitBeforeGoingToTheNextPosition()
    {
        
        yield return new WaitForSeconds(Random.Range(2.0f,5.0f));


        if (reverse == true)
        {
            currentPosition--;

            if (currentPosition == 0)
            {
                reverse = false;
                currentPosition = 0;
            }
        }
        else
        {
            currentPosition++;

            if (currentPosition == waypoints.Count)
            {
                reverse = true;
                currentPosition--;
            }
        }

            targetPositionReached = false;
    }
}
