using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class AstroidSpawner : MonoBehaviour
{
    [SerializeField] GameObject largeAsteroid;
    [SerializeField] GameObject mediumAsteroid;
    [SerializeField] GameObject smallAsteroid;
    [SerializeField] int minLarge;
    [SerializeField] int maxLarge;
    [SerializeField] int minMed;
    [SerializeField] int maxMed;
    [SerializeField] int minSmall;
    [SerializeField] int maxSmall;
    public void spawnAsteroids()
    {
        int largeNo  = Random.Range(minLarge, maxLarge);
        int medNo =  Random.Range(minMed, maxMed);
        int smallNo = Random.Range(minSmall, maxSmall);

        for(int i=0; i < largeNo; i++)
        {
            Vector2 point = Random.insideUnitCircle * 20;
            Instantiate(largeAsteroid, new Vector2(transform.position.x,transform.position.y)+point, new Quaternion(0, 0, 0, 0),transform); 
        }
        for(int i=0; i < medNo; i++)
        {
            Vector2 point = Random.insideUnitCircle * 20;
            Instantiate(mediumAsteroid, new Vector2(transform.position.x, transform.position.y) + point, new Quaternion(0, 0, 0, 0),transform);
        }
        for(int i=0; i<smallNo; i++)
        {
            Vector2 point = Random.insideUnitCircle * 20;
            Instantiate(smallAsteroid, new Vector2(transform.position.x, transform.position.y) + point, new Quaternion(0, 0, 0, 0),transform);
        }
    }
    public void killasteroids()
    {
        foreach(Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}
