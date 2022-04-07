using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitcher : MonoBehaviour
{
    public GameObject obj1, obj2;
    bool x = true;


    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (x == true)
            {

                obj2.SetActive(true);
                obj1.SetActive(false);

                x = false;
            }
           else if( x == false)
            {
                obj2.SetActive(false);
                obj1.SetActive(true);

                x = true;


            }




        }
    }
}
