using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUps : MonoBehaviour
{
    public CharacterControl playerHealthScript;

    public int healthBonus = 5;

    private void Awake()
    {
        playerHealthScript = FindObjectOfType<CharacterControl>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (playerHealthScript.playerHealth < playerHealthScript.maxHealth)
        {
            Destroy(gameObject);
            if((playerHealthScript.maxHealth - playerHealthScript.playerHealth)< healthBonus) 
            {
                playerHealthScript.playerHealth = playerHealthScript.maxHealth;
            } else {
                playerHealthScript.playerHealth += healthBonus;
            }
        }
    }
}
