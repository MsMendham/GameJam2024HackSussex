using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UiManagerShop : MonoBehaviour
{
    [SerializeField] private string planetName;
    [SerializeField] private Text UIHeader;
    [SerializeField] private ShipStats stats;


    private void Awake()
    {
        UIHeader.text = planetName;
    }
    public void OnDeliver()
    {
        float amountDelivered = 0;
        foreach(DeliveryScript i in stats.Cargo)
        {
            if(i.Destination == planetName)
            {
                amountDelivered += i.quantity;
            }
        }
        UIHeader.text = "You delivered " + amountDelivered.ToString() + " tonnes of cargo";
    }
}
