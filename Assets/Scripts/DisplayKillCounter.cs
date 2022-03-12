/* Team 1
 * Project 2
 * Displays number of enemies killed
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayKillCounter : MonoBehaviour
{
    public Text textbox;
    //made static for flag script
    public static int killCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        textbox = GetComponent<Text>();
        textbox.text = "Kills: " + killCounter;
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Kills: " + killCounter;
    }
}
