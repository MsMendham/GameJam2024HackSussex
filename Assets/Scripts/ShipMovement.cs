using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] private float thrust;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float maxLinearVel;
    [SerializeField] private float maxAngularVel;
    [SerializeField] private AudioSource audioSrc;

    private Rigidbody2D rb;

    private Vector2 moveValue;
    private float rotValue;

    public Vector2 linVel;

    private SpriteRenderer _spriteRenderer;
    [SerializeField]
    private Sprite[] sprites;
    private int spriteVersion = 0;

    
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Sprites();
    }
    private void FixedUpdate()
    {
        applyMove();
        applyRotate();
        linVel = rb.velocity;
    }

    public void applyMove()
    {
        rb.AddRelativeForce(moveValue * thrust * new Vector2(0.5f, 1));
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxLinearVel);
    }

    public void applyRotate()
    {
        rb.AddTorque(rotValue * rotationSpeed);
        rb.angularVelocity = Mathf.Clamp(rb.angularVelocity,-maxAngularVel,maxAngularVel);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveValue = context.ReadValue<Vector2>();
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        rotValue = context.ReadValue<float>();
    }

    public void Sprites()
    {
        //0 is defualt, forward, strafe right, strafe left, rotate right, left
        if (rotValue < 0)
        {
            // rotate right sprite
            spriteVersion = 4;
            playSound();
        }
        if (rotValue > 0)
        {
            // rotate left sprite
            spriteVersion = 5;
            playSound();
        }
        if (moveValue.x > 0)
        {
            // strafe right sprite
            spriteVersion = 2;
            playSound();
        }
        if (moveValue.x < 0)
        {
            // strafe left sprite
            spriteVersion = 3;
            playSound();
        }
        if (moveValue.y > 0)
        {
            // forward sprite
            spriteVersion = 1;
            playSound();
        }
        if (moveValue.y == 0 && moveValue.x == 0 && rotValue == 0)
        {
            //deafult sprite
            spriteVersion = 0;
            stopSound();
        }
        _spriteRenderer.sprite = sprites[spriteVersion];
    }

    private void playSound()
    {
        if (!audioSrc.isPlaying)
        {
            Debug.Log("play");
            audioSrc.Play();
        }
    }
    private void stopSound()
    {
        if (audioSrc.isPlaying)
        {
            Debug.Log("Stop");
            audioSrc.Stop();
        }
    }
}
