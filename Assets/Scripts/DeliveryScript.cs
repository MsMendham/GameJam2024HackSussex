using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DeliveryScript : ScriptableObject
{
    public Cargos cargo;
    public string Destination;
    public float quantity;
    public float time;
}
public enum Cargos
{
    Blahaj,
    SmolHaj,
    Djungelskog,
    Blavingrad
}
