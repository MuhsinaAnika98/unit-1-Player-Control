using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private float speed=15f ;//forward-backward movement speed


    private float turnSpeed=40f ;//speed for left-right turn

    private float horizontalInput;
    private float verticalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");

        verticalInput = Input.GetAxis("Vertical");

        // transform.Translate(0,0,1);
        //  transform.Translate(Vector3.forward);
        //  same work as before but easier to understand
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput);
        //manipulating vehicle's speed & control it with uparrow


       // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed*horizontalInput);  turning  the car in left and right direction using right and left aroow 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput); //using rotation instead of Translate for more realistic turning


    }
   
}
