﻿/* Team 1
 * Project 2
 * Controls flag level change
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagBehavior : MonoBehaviour
{
    //public DisplayKillCounter Score;

    // Update is called once per frame
    void Update()
    {
        
    }
    //if player collides with flag the next scene is loaded
    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.tag == "Player") && (DisplayKillCounter.killCounter >= 5))
        {
            //reset score each level
            DisplayKillCounter.killCounter = 0;
            //load next scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
