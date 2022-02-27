using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPowerUp : MonoBehaviour
{
    public PlayerAttackDamage damageScript;
    
    public int damageBonus;
    private void Awake()
    {
        damageScript = FindObjectOfType<PlayerAttackDamage>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //damageScript.damage *= 2;
    }
}
