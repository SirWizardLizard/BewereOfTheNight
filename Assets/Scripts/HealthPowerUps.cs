/* Team 1
 * Project 2
 * controls aspects of health power ups
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUps : MonoBehaviour
{
    public PlayerHealth playerHealthScript;

    public GameObject pickupEffect;

    public int healthBonus = 10;

    private void Awake()
    {
        playerHealthScript = FindObjectOfType<PlayerHealth>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (playerHealthScript.playerHealth < playerHealthScript.maxHealth)
        {
            Instantiate(pickupEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            playerHealthScript.playerHealth += healthBonus;
        }
    }
}
