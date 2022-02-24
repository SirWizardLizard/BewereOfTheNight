using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth = 20;
    public static bool isEnemyDead = false; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        if (currentHealth <= 0 && isEnemyDead == false)
        {
            Debug.Log("Dead" + currentHealth);
            //gameObject.GetComponent<Animator>().play("Dying");
            isEnemyDead = true; 
        }
    }
}
