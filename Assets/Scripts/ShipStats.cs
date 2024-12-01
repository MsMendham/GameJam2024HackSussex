using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipStats : MonoBehaviour
{
    [SerializeField] private float initfrontHealth = 10;
    [SerializeField] private float initmiddleHealth = 10;
    [SerializeField] private float initbackHealth = 10;
    [SerializeField] public List<DeliveryScript> Cargo;

    [SerializeField] Collider2D frontCollider;
    [SerializeField] Collider2D middleCollider;
    [SerializeField] Collider2D backCollider;
    [SerializeField] UiManager uiManager;
    private float frontHealth;
    private float middleHealth;
    private float backHealth;

    private void Awake()
    {
        frontHealth = initfrontHealth;
        middleHealth = initmiddleHealth;
        backHealth = initbackHealth;
        Cargo = new List<DeliveryScript>();
    }


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
        uiManager.reduceBowHealth(dmg/initfrontHealth);
        Debug.Log(dmg / initfrontHealth);
    }
    public void middleHit(int dmg)
    {
        middleHealth -= dmg;
        uiManager.reduceCargoHealth(dmg / initmiddleHealth);
    }
    public void backHit (int dmg)
    {
        backHealth -= dmg;
        uiManager.reduceBridgeHealth(dmg / initbackHealth);
    }
}
