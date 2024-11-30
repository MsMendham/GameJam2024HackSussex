using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;
    private SpriteRenderer SR;

    private void Awake()
    {
        SR = GetComponent<SpriteRenderer>();
        SR.sprite = sprites[Random.Range(0, sprites.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
