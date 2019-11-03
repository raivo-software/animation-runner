using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxVelocity = 10;
    public float timeToMax = 5;

    private CharacterController characterController;
    private Animator animator;
    private float velocity = 0;
    private Vector3 horizontalDirection;
    private Vector3 speed;
    private Vector3 startPosition;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        startPosition = transform.position;
    }

    void Update()
    {
        Vector3 currentDirection = Vector3.zero;
        if (Input.GetKey("w"))
            currentDirection += Vector3.forward;
        if (Input.GetKey("a"))
            currentDirection += Vector3.left;
        if (Input.GetKey("s"))
            currentDirection += Vector3.back;
        if (Input.GetKey("d"))
            currentDirection += Vector3.right;
        if(currentDirection.magnitude > 0)
        {
            horizontalDirection = currentDirection;
            if (velocity < maxVelocity)
                velocity = Mathf.Min(maxVelocity, velocity + maxVelocity * (Time.deltaTime / timeToMax));
        }
        if (currentDirection.magnitude == 0)
            velocity = Mathf.Max(0, velocity - maxVelocity * (Time.deltaTime / (timeToMax / 2)));
        transform.LookAt(transform.position + horizontalDirection);

        Vector3 horizontalSpeed = horizontalDirection * velocity;
        speed = new Vector3(horizontalSpeed.x, speed.y, horizontalSpeed.z);
        if (characterController.isGrounded)
        {
            speed.y = 0;
            if (Input.GetKeyDown("space"))
            {
                speed.y = 10;
            }
        }
        speed.y -= 9 * Time.deltaTime;
        characterController.Move(speed * Time.deltaTime);

        if(transform.position.y < -10)
        {
            transform.position = startPosition;
            speed = Vector3.zero;
            velocity = 0;
        }

    }

    public float GetSpeed()
    {
        return velocity;
    }

    public bool IsGrounded()
    {
        return characterController.isGrounded;
    }
}
