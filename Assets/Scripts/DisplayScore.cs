/* Team 1
 * Project 2
 * displays score UI
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//we neeed UI for ui
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    //create a text object
    public Text scoreText;
    //integer value for score
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //set the component reference on start
        scoreText.text = " Score: 0";
    }

    // Update is called once per frame
    void Update()
    {   //updates score everyframe
        scoreText.text = "Score: " + score;
    }
}
