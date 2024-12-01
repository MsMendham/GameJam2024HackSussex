using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetScrolling : MonoBehaviour
{
    public float scrollSpeed;

    private Renderer renderer;
    private Vector2 savedOffset;
    [SerializeField] private GameObject player;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        
        Vector2 offset = player.transform.position *scrollSpeed;
        renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);

        transform.position = new Vector3(player.transform.position.x, player.transform.position.y,transform.position.z);
    }
}