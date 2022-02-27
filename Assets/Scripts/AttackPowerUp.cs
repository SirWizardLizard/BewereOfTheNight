using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPowerUp : MonoBehaviour
{
    public PlayerAttack damageScript;

    public GameObject pickupEffect;

    public int multiplier = 2;

    public float duration = 5f;
    
    public int damageBonus;
    private void Awake()
    {
        damageScript = FindObjectOfType<PlayerAttack>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        damageScript.damage *= multiplier;

        GetComponent<SpriteRenderer>().enabled = false;

        GetComponent<Collider2D>().enabled = false;

        yield return new WaitForSeconds(duration);

        damageScript.damage /= multiplier;

        Destroy(gameObject);
    }
}
