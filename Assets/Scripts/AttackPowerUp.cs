using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPowerUp : MonoBehaviour
{
    public PlayerAttack damageScript;
    
    public int damageBonus;
    private void Awake()
    {
        damageScript = FindObjectOfType<PlayerAttack>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            damageScript.damage *= 2;
        }
    }
}
