using UnityEngine.InputSystem;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody rb;
    private float movementX;
    private float movementY;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() 
    {
        Move();
    }

    private void Move() 
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY).normalized;

        rb.AddRelativeForce(transform.forward + movement * speed);
    }
    
    void OnMove(InputValue movementValue)  
    { 
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }
}