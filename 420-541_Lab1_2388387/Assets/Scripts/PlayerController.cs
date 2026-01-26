using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
     float horizontalInput = Input.GetAxis("Horizontal");   
     float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate(movement * speed * Time.deltaTime);
        
    }
}
