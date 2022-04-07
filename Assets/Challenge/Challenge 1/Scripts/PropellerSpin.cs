using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    float rotationSpeed = 500f;
   
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime );
    }



}
