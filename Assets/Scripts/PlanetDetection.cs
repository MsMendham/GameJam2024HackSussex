using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetDetection : MonoBehaviour
{
    private Collider2D collider;
    void Start()
    {
        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Planet"))
        {
            Debug.Log("at planet");
        }
        
    }

}
