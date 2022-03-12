/* Team 1
 * Project 2
 * Controls flag level change
 * variant for tutorial levels where there arent 5 enemies
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagBehaviorTutorial : MonoBehaviour
{

    //if player collides with flag the next scene is loaded
    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.tag == "Player"))
        {
            //reset score each level
            DisplayKillCounter.killCounter = 0;
            //load next scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
