using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Mover : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right*speed* Time.deltaTime);
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + Vector3.right * speed* Time.fixedDeltaTime);

    }
}
