using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] private Scrollbar scrollBow;
    [SerializeField] private Scrollbar scrollCargo;
    [SerializeField] private Scrollbar scrollBridge;

    // Start is called before the first frame update
    public void reduceBowHealth(float amount)
    {
        scrollBow.size -= amount;
    }

    public void reduceCargoHealth(float amount)
    {
        scrollCargo.size -= amount;
    }
    
    public void reduceBridgeHealth(float amount)
    {
        scrollBridge.size -= amount;
    }
}
