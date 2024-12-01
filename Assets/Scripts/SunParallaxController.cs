using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunParallaxController : MonoBehaviour
{
    [SerializeField] private GameObject cam;
    [SerializeField] private float parallaxEffect;
    [SerializeField] private float VparallaxEffect;
    private float length;
    private float startpos;
    private float startposY;

    private void Awake()
    {
        startpos = transform.position.x;
        startposY = transform.position.y;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);

        float vDist = cam.transform.position.y * VparallaxEffect;

        transform.position = new Vector3(startpos + dist, startposY+vDist, transform.position.z);

        if (temp > startpos + length) startpos += length;
        else if (temp < startpos - length) startpos -= length;
    }
}
