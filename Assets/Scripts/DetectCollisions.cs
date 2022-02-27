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

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
