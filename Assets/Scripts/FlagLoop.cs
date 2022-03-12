/* Team 1
 * Project 2
 * Controls flag level change for level 6 originally looped to 1, now will show winning screen
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagLoop : MonoBehaviour
{
   
    //if player collides with flag the next scene is loaded
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
