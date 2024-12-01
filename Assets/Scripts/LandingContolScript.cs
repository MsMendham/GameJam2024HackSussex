using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LandingContolScript : MonoBehaviour
{
    [SerializeField] private float upthrust;
    [SerializeField] private float sidethrust;
    [SerializeField] private float rotSpeed;
    [SerializeField] private Sprite[] sprites;

    private float upValue;
    private float sideValue;
    private float rotValue;
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        SpriteFunc();
    }

    private void FixedUpdate()
    {
        applyUp();
        applySideways();
        applyRotate();
    }

    private void applyUp()
    {
        rb.AddRelativeForce(new Vector2(0, upValue * upthrust));
    }
    private void applySideways()
    {
        rb.AddRelativeForce(new Vector2(sideValue * sidethrust, 0));
    }

    private void applyRotate()
    {
        rb.AddTorque(rotValue * rotSpeed);
    }

    public void OnUp(InputAction.CallbackContext context)
    {
        
        upValue = context.ReadValue<float>();
        
    }
    
    public void OnSideways(InputAction.CallbackContext context)
    {
        sideValue = context.ReadValue<float>();
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        rotValue = context.ReadValue<float>();
        Debug.Log(rotValue);
    }

    private void SpriteFunc()
    {
        int spriteIndex = 0;
        if (upValue > 0)
        {
            spriteIndex = 1;
        }
        if (sideValue > 0)
        {
            spriteIndex = 2;
        }
        if (sideValue < 0)
        {
            spriteIndex = 3;
        }
        if(rotValue > 0)
        {
            spriteIndex = 4;
        }
        if(rotValue < 0)
        {
            spriteIndex = 5;
        }

        sr.sprite = sprites[spriteIndex];
    }
}
