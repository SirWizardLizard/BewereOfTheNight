using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack; 

    public Transform attackPos; 
    public LayerMask whatIsEnemy; 
    public float attackRange; 
    public int damage;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwAttack <=0)
        {
            if (Input.GetMouseButton(0))
            {
                //Debug.Log("The left mouse button has been clicked");
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemy);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    //Debug.Log("The enemy has been hit! Huzzah!");
                    currentHealth = enemiesToDamage[i].GetComponent<EnemyMovement>().health -= damage;
                    enemiesToDamage[i].GetComponent<HealthBar>().SetHealth(currentHealth);
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
