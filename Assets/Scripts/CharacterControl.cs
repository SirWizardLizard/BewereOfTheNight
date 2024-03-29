﻿/* Team 1
 * Project 2
 * allows player control
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class CharacterControl : MonoBehaviour
{
    private Animator anim;
    public GameObject textbox;
    public Transform player;
    public Vector3 offset;
    private AudioSource playerAudio; 
    public AudioClip jump; 
    public AudioClip barking; 
    public int playerHealth;
    public int maxHealth;
    // Move player in 2D space
    public float maxSpeed = 3.4f;
    public float jumpHeight = 6.5f;
    public float gravityScale = 1.5f;
    public Camera mainCamera;
    //AudioSource jumpSound; 
    bool facingRight = true;
    float moveDirection = 0;
    bool isGrounded = false;
    bool isOnGround = true;
    //made static for r to restart 
    public static bool gameOver = false;
    Vector3 cameraPos;
    Rigidbody2D r2d;
    CapsuleCollider2D mainCollider;
    Transform t;
    public bool isMoving; 

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>(); 
        //Set the starting health to the players max health
        playerHealth = maxHealth;
        playerAudio = GetComponent<AudioSource>(); 
        t = transform;
        r2d = GetComponent<Rigidbody2D>();
        mainCollider = GetComponent<CapsuleCollider2D>();
        r2d.freezeRotation = true;
        r2d.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        r2d.gravityScale = gravityScale;
        facingRight = t.localScale.x > 0;
        //textbox = GameObject.FindGameObjectWithTag("GameOverText");

    }

    // Update is called once per frame
    void Update()
    {
        // Movement controls
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) && !gameOver)
        {
            moveDirection = Input.GetKey(KeyCode.A) ? -1 : 1;
            anim.SetBool("isMoving", true);
        }
        else
        {
            if (isGrounded || r2d.velocity.magnitude < 0.01f)
            {
                anim.SetBool("isMoving", false);
                moveDirection = 0;
            }
        }

       if (Input.GetKey(KeyCode.Mouse0))
        {
            anim.SetBool("isBiting",true);
             playerAudio.PlayOneShot(barking, .5F); 
        } else
        {
            anim.SetBool("isBiting",false);
        }

        // Change facing direction
        if (moveDirection != 0 && !gameOver)
        {
            if (moveDirection > 0 && !facingRight)
            {
                facingRight = true;
                t.localScale = new Vector3(Mathf.Abs(t.localScale.x), t.localScale.y, transform.localScale.z);
            }
            if (moveDirection < 0 && facingRight)
            {
                facingRight = false;
                t.localScale = new Vector3(-Mathf.Abs(t.localScale.x), t.localScale.y, t.localScale.z);
            }
        }

        // Jumping
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)) && isGrounded && !gameOver)
        {
            isGrounded = false; 
            playerAudio.PlayOneShot(jump, 1.0F); 
            r2d.velocity = new Vector2(r2d.velocity.x, jumpHeight);
        }

        //Kill player if health hits 0
        if(playerHealth <= 0) {
          //  Destroy(gameObject);
            gameOver = true;
        }

        //Kill player if their y value falls below -2 and set the game to be over.
        if (transform.position.y < -2) {
            gameOver = true;
          //  Destroy(gameObject);
            //commment out to add r to restart
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


    void FixedUpdate()
    {
        Bounds colliderBounds = mainCollider.bounds;
        float colliderRadius = mainCollider.size.x * 0.4f * Mathf.Abs(transform.localScale.x);
        Vector3 groundCheckPos = colliderBounds.min + new Vector3(colliderBounds.size.x * 0.5f, colliderRadius * 0.9f, 0);
        // Check if player is grounded
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckPos, colliderRadius);
        //Check if any of the overlapping colliders are not player collider, if so, set isGrounded to true
        isGrounded = false;
        if (colliders.Length > 0)
        {
            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i] != mainCollider)
                {
                    isGrounded = true;
                    break;
                }
            }
        }

        // Apply movement velocity
        r2d.velocity = new Vector2((moveDirection) * maxSpeed, r2d.velocity.y);

        // Simple debug
        Debug.DrawLine(groundCheckPos, groundCheckPos - new Vector3(0, colliderRadius, 0), isGrounded ? Color.green : Color.red);
        Debug.DrawLine(groundCheckPos, groundCheckPos - new Vector3(colliderRadius, 0, 0), isGrounded ? Color.green : Color.red);
    }
    
}