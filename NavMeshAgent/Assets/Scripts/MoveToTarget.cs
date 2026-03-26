using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
       public Transform target;   // drag the Target sphere here in the Inspector

NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = target.position;  // send agent to target on Start
    }

}
