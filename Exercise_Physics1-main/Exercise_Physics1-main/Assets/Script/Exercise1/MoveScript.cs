using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    float timer = 1.0f;
    float direction = 1.0f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        transform.Translate(Vector3.right * direction * Time.deltaTime * 2.0f);
        if (timer <= 0.0f)
        {
            direction *= -1.0f;
            timer = 1.0f;
        }
    }
}
