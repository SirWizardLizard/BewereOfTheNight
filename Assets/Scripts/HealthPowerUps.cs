using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUps : MonoBehaviour
{
    public PlayerHealth playerHealthScript;

    private bool triggered;

    // Start is called before the first frame update
    void Start()
    {
        playerHealthScript = GameObject.FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Health") && !triggered)
        {
            triggered = true;
            playerHealthScript.playerHealth += 20;
        }
    }
}
