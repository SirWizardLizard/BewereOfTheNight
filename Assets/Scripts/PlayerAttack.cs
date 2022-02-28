using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public AudioClip bark; 
    private AudioSource playerAudio; 
    private float timeBtwAttack;
    public float startTimeBtwAttack; 

    public Transform attackPos; 
    public LayerMask whatIsEnemy; 
    public float attackRange; 
    public int damage;
    public int currentHealth;
    AudioSource playerBite; 

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwAttack <=0)
        {
            if (Input.GetMouseButton(0))
            {
                
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemy);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    
                    enemiesToDamage[i].GetComponent<EnemyMovement>().health -= damage; 
                    playerAudio.PlayOneShot(bark, 0.7F);
                }
            }
            timeBtwAttack = startTimeBtwAttack;
        }   else {
            timeBtwAttack -= Time.deltaTime; 
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
