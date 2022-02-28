using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayKillCounter : MonoBehaviour
{
    public Text textbox;
    public int killCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
        textbox.text = "Kills: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Kills: " + killCounter;
    }
}
