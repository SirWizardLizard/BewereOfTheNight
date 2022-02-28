using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUps : MonoBehaviour
{
    public CharacterControl playerHealthScript;

    public GameObject pickupEffect;

    public int healthBonus = 5;

    private void Awake()
    {
        playerHealthScript = FindObjectOfType<CharacterControl>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (playerHealthScript.playerHealth < playerHealthScript.maxHealth)
        {
            Instantiate(pickupEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            if((playerHealthScript.maxHealth - playerHealthScript.playerHealth)< healthBonus) 
            {
                other.GetComponent<HealthBar>().SetHealth(playerHealthScript.playerHealth = playerHealthScript.maxHealth);
            } else {
                other.GetComponent<HealthBar>().SetHealth(playerHealthScript.playerHealth += healthBonus);
                
            }
        }
    }
}
