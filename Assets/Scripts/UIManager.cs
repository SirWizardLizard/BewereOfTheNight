using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public CharacterControl playerScript;

    public Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        if (playerScript == null)
        {
            playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterControl>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.gameOver)
        {
            gameOverText.text = "Game over!\nPress R to Try Again";
        }
        
        if (playerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
