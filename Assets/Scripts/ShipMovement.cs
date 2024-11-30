using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] private float thrust;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float maxLinearVel;
    [SerializeField] private float maxAngularVel;

    private Rigidbody2D rb;

    private Vector2 moveValue;
    private float rotValue;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        applyMove();
        applyRotate();
    }

    public void applyMove()
    {
        rb.AddRelativeForce(moveValue * thrust * new Vector2(0.5f, 1));
    }

    public void applyRotate()
    {
        rb.AddTorque(rotValue * rotationSpeed);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveValue = context.ReadValue<Vector2>();
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        rotValue = context.ReadValue<float>();
    }
}
