using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

    [SerializeField] private LayerMask jumpableGround;

    private float dirX = 0f;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;

    private enum MovementState { idle, running, jumping, falling }
    MovementState state;

    [SerializeField] private AudioSource jumpSoundEffect;

    // Start is called before the first frame update




    //variable for mobile control
    private bool moveLeft; // define boolean variable for moving left
    private bool moveRight; // define boolean variable for moving right
    private bool Jump; // define boolean variable for Jump



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        //dirX = Input.GetAxisRaw("Horizontal");
        //rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        //test
        
        if (Input.GetAxisRaw("Horizontal") != 0f)
        {
            dirX = Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
            UpdateAnimationState();
        }
        else
        {
            // if I press the left button
            if (moveLeft)
            {
                dirX = -moveSpeed;
                rb.velocity = new Vector2(dirX, rb.velocity.y);
                //UpdateAnimationState();
                MovementPlayer();
            }

            // if I press the right button

            else if (moveRight)
            {
                dirX = moveSpeed;
                rb.velocity = new Vector2(dirX, rb.velocity.y);
                //UpdateAnimationState();
                MovementPlayer();
            }

            // if I don't press any button
            else
            {
                dirX = 0f;
                rb.velocity = new Vector2(dirX, rb.velocity.y);
                //UpdateAnimationState();
                MovementPlayer();
            }
        }

        if ((Input.GetButtonDown("Jump") && IsGrounded()) || Jump)
        {
            //jumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);

        }


        //MovementPlayer();

        //UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        MovementState state;

        if (dirX > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        if (rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }

        anim.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }










    //code for mobile controll

    // I am pressing the left button
    public void PointerDownLeft()
    {
        moveLeft = true;
        state = MovementState.running;
        sprite.flipX = true;
    }





    // I am not pressing the left button
    public void PointerUpLeft()
    {
        moveLeft = false;
        state = MovementState.idle;
    }





    // repeat the above two steps with the right button
    // I am pressing the right button
    public void PointerDownRight()
    {
        moveRight = true;
        state = MovementState.running;
        sprite.flipX = false;
    }





    // I am not pressing the right button
    public void PointerUpRight()
    {
        moveRight = false;
        state = MovementState.idle;
    }





    // I am pressing the left button
    public void PointerDownJump()
    {
        if (IsGrounded())
        {
            //rb.velocity = Vector2.up * jumpForce;
            //rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            Jump = true;
            state = MovementState.jumping;
        }
    }





    // I am not pressing the left button
    public void PointerUpJump()
    {
        Jump = false;
        state = MovementState.idle;
    }





    private void MovementPlayer()
    {
        // if I press the left button
        if (moveLeft)
        {
            dirX = -moveSpeed;
            UpdateAnimationState();
        }

        // if I press the right button

        else if (moveRight)
        {
            dirX = moveSpeed;
            UpdateAnimationState();
        }

        // if I don't press any button
        else
        {
            dirX = 0f;
            UpdateAnimationState();
        }
    }






    //public void jumpButton()
    //{
        //if (IsGrounded())
        //{
            //rb.velocity = Vector2.up * jumpForce;
            //rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        //}
    //}

}
