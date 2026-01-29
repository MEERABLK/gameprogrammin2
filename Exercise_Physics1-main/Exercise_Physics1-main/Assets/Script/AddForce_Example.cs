using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce_Example : MonoBehaviour
{
    public float jumpStrength = 10f;
    public bool isButtonPressed;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>() ;
    }

    // Update is called once per frame
    void Update()
    {
        isButtonPressed = Input.GetButtonDown("Jump");

    }

       void FixedUpdate()
    {
       if( isButtonPressed)
        {
            rb.AddForce(Vector3.up* jumpStrength,ForceMode.Impulse);
            isButtonPressed= false;
            
        }

    }
}
