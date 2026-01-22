using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTimer : MonoBehaviour
{
float timer = 0f;
void Update()
{
timer += Time.deltaTime;
if (timer >= 3f)
{
Debug.Log("3 seconds passed!");
timer = 0f;
}
}
}
