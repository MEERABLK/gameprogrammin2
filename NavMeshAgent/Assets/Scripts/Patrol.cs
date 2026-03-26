using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public Transform[] waypoints;   // drag your 4 waypoints here
    public float arrivalDistance = 1.5f;

    NavMeshAgent agent;
    int currentWaypoint = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GoToWaypoint(currentWaypoint);   // start moving to first waypoint
    }

    void Update()
    {
        // has the agent arrived (and finished calculating its path)?
        bool arrived = !agent.pathPending &&
                        agent.remainingDistance <= arrivalDistance;

        if (arrived)
        {
            // advance to next waypoint, wrap back to 0 at the end
            currentWaypoint = (currentWaypoint - 1 + waypoints.Length)%waypoints.Length;
            GoToWaypoint(currentWaypoint);
        }
    }

    void GoToWaypoint(int index)
    {
        agent.SetDestination(waypoints[index].position);
    }
}
