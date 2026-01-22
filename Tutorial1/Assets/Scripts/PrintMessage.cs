using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintMessage : MonoBehaviour
{
    // Start is called before the first frame update
void Start()
{
Debug.Log("Hello Unity!");
}


    // Update is called once per frame
    void Update()
    {
if (Input.GetKeyUp(KeyCode.Space))     
{
    Debug.Log("hbdb");
}   
    }
}
