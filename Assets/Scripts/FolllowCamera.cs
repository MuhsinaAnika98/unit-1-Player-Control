using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolllowCamera : MonoBehaviour
{
    public GameObject player;


    Vector3 offset = new Vector3(1,5,-10);
    void Start()
    {
        
    }

  
    void LateUpdate() // always use camera follow in late update so the camera position will be updated always after the player position .
    {
        //  transform.position = player.transform.position+new Vector3(19, 4, 10) ;transform.position = player.transform.position+new Vector3(19, 4, 10) ;  adding the camera position so it will stay in place and update its position accordingly
        transform.position = player.transform.position + offset;
    }

}
