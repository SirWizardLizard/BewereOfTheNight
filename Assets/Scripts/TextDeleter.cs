/* Team 1
 * Project 2
 * manages tutorial text deletion on entering trigger zone
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDeleter : MonoBehaviour
{
    public Text tutorialText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.tag == "Player"))
        {
            tutorialText.text = "";
        }
    }
}
