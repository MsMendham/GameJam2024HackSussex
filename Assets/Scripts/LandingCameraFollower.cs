using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingCameraFollower : MonoBehaviour
{
    [SerializeField] GameObject player;

    private Vector3 offset = new Vector3(0, 0, -10);

    private void Update()
    {
        transform.position = player.transform.position+offset;
       
        if(transform.position.y < 0)
        {
            transform.position = new Vector3(transform.position.x,0,transform.position.z);
        }
    }



}
