using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPowerUp : MonoBehaviour
{
    public PlayerAttackDamage damageScript;
    private bool triggered;

    // Start is called before the first frame update
    void Start()
    {
        damageScript = GameObject.FindObjectOfType<PlayerAttackDamage>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider other)
    {
        if (other.CompareTag("Attack") && !triggered)
        {

        }
    }
}
