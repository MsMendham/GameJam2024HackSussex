using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 offset = new Vector3(0,0,-10);
    void Start()
    {
        transform.position = player.position+offset;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
