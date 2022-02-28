using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private AudioSource enemyAudio; 
    public AudioClip slash; 
    // start is called before the first frame update
    public float speed;
    public int maxHealth;
    public float speed; 
    public int enemyDamage; 
    public int health; 
    public Transform groundDetection; 
    private bool moveRight = true; 
    public float Raycast; 
    public float Raylength;

    public HealthBar healthBar;

    void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        enemyAudio = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject); 
        }

        transform.Translate(Vector2.right * speed * Time.deltaTime); 
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down,Raylength); 
        if (groundInfo.collider == false)
        {
            if (moveRight == true)
            {
                transform.eulerAngles = new Vector3(0,-180,0);
                moveRight = false; 
            } 
            else
            {
            transform.eulerAngles = new Vector3(0,0,0); 
            moveRight = true;
            }
        } 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            enemyAudio.PlayOneShot(slash, 1.0F);
            //collision.GetComponent<what ever the player health thing is called>().enemyDamage()
        }
    }
}
