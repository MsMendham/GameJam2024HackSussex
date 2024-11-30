using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipStats : MonoBehaviour
{
    [SerializeField] private int frontHealth = 10;
    [SerializeField] private int middleHealth = 10;
    [SerializeField] private int backHealth = 10;

    [SerializeField] Collider2D frontCollider;
    [SerializeField] Collider2D middleCollider;
    [SerializeField] Collider2D backCollider;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.otherCollider == frontCollider)
        {
            frontHit(1);
        }
        if(collision.otherCollider == middleCollider)
        {
            middleHit(1);
        }
        if(collision.otherCollider == backCollider)
        {
            backHit(1);
        }
    }

    public void frontHit(int dmg)
    {
        frontHealth -= dmg;
    }
    public void middleHit(int dmg)
    {
        middleHealth -= dmg;
    }
    public void backHit (int dmg)
    {
        backHealth -= dmg;
    }
}
