using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlanetDetection : MonoBehaviour
{
    private bool infieldflag = false;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!infieldflag)
        {
            infieldflag = true;

            if (collision.CompareTag("Planet"))
            {
                Debug.Log("at planet");
            }
            if (collision.CompareTag("Asteroid Field"))
            {
                Debug.Log("spawn field");
                collision.gameObject.GetComponent<AstroidSpawner>().spawnAsteroids();
            }
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Asteroid Field"))
        {
            collision.gameObject.GetComponent<AstroidSpawner>().killasteroids();
        }

        infieldflag = false;
    }

}
