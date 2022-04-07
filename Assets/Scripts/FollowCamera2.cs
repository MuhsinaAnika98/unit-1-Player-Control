using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;


    Vector3 offset = new Vector3(1, 5, 21);

    private void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
