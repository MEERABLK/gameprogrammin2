using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CratePusher : MonoBehaviour
{
    public float speed   = 2f;
    public float distance = 8f;   // how far to slide

    Vector3 startPos;

    void Start() { startPos = transform.position; }

    void Update()
    {
        // oscillate along the X axis using a sine wave
        float offset = Mathf.Sin(Time.time * speed) * distance;
        transform.position = startPos + new Vector3(offset, 0, 0);
    }

}
