/* Team 1
 * Project 2
 * controls player health
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100; 
    public int playerHealth; 
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = maxHealth; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerTakeDamage(int damage)
    {
        playerHealth = playerHealth - damage; 
    }
}
