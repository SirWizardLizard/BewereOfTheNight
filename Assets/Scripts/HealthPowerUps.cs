using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUps : MonoBehaviour
{
    public PlayerHealth playerHealthScript;

    public int healthBonus = 10;

    private void Awake()
    {
        playerHealthScript = FindObjectOfType<PlayerHealth>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (playerHealthScript.playerHealth < playerHealthScript.maxHealth)
        {
            Destroy(gameObject);
            playerHealthScript.playerHealth += healthBonus;
        }
    }
}
