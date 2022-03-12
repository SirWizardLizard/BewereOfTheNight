/* Team 1
 * Project 2
 * destroys health power ups (I don't think we used it.  Just don't want to break anything)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public HealthPowerUps healthPowerUpScript;

    // Start is called before the first frame update
    void Start()
    {
        healthPowerUpScript = GameObject.FindGameObjectWithTag("Health").GetComponent<HealthPowerUps>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
