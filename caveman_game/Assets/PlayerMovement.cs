using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Declaring variables
    // The reason this is a float is for precision
    [SerializeField] public float moveSpeed;
    [SerializeField] public Rigidbody2D rb;
    // WE WILL NEED THIS LATER, DO NOT DELETE IT!
    // [SerializeField] public Animator animator;

    // These variables will store the move speed and direction
    float mx;
    float my;
    Vector2 moving;

    void Update()
    {
        // Gets the direction in positive or negative numbers, depending on key press
        float mx = Input.GetAxisRaw("Horizontal");
        float my = Input.GetAxisRaw("Vertical");

        // New Vector2 gets the direction
        // which is normalized (changes things to 1, -1, or 0)
        // which is then multiplied by the movespeed (set in the editor)
        moving = new Vector2(mx, my).normalized * moveSpeed;

        // Animation stuff
        // WE WILL NEED THIS LATER, DO NOT DELETE IT!
        // animator.SetFloat("Horizontal", mx);
        // animator.SetFloat("Vertical", my);
        // animator.SetFloat("Speed", moving.sqrMagnitude);
    }

    void FixedUpdate()
    {
        // the rigidbody's velocity is set to moving (which should return something like [-1, 0])
        // multiplying it by Time.fixedDeltaTime with ensure that it runs the same on all systems
        rb.velocity = moving * Time.fixedDeltaTime;
    }
}
