using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    //Don't know where first went?
    //Variables needed for movement
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    // saves x,y
    Vector2 movement;

    public Animator animator;
    
    // Update is called once per frame
    void Update()
    {
        //Input
        // Using keys left and right, if that key pressed is detected it's reported here.
        // If nothing is detected it will return 0, if it's left it will return -1, right 1
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
