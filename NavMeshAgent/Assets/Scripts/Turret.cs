using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
        public Transform player;
    public float viewAngle    = 60f;
    public float viewDistance = 10f;
    public LayerMask obstacleMask;

    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(0, Mathf.Sin(Time.time) * 45f, 0);
        if (CanSeePlayer())
            rend.material.color = Color.red;
        else
            rend.material.color = Color.white;


    }

    bool CanSeePlayer()
    {
        Vector3 toPlayer = player.position - transform.position;

        // Step 1 — Distance
        if (toPlayer.magnitude > viewDistance)
            return false;
        float angle = Vector3.Angle(transform.forward, toPlayer); 
        if (angle > viewAngle) return false; 
        // Step 2 — Angle (dot product)
        //float dot       = Vector3.Dot(transform.forward, toPlayer.normalized);
       // float threshold = Mathf.Cos(viewAngle * Mathf.Deg2Rad);
        //if (dot < threshold)
        //    return false;

        // Step 3 — Line of sight (raycast)
        if (Physics.Raycast(transform.position, toPlayer.normalized,
                            toPlayer.magnitude, obstacleMask))
            return false;

        return true;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, viewDistance);

        Vector3 left  = Quaternion.Euler(0, -viewAngle, 0) * transform.forward;
        Vector3 right = Quaternion.Euler(0,  viewAngle, 0) * transform.forward;
        Gizmos.color = new Color(1f, 0.5f, 0f, 0.5f);
        Gizmos.DrawRay(transform.position, left  * viewDistance);
        Gizmos.DrawRay(transform.position, right * viewDistance);
    }
}


