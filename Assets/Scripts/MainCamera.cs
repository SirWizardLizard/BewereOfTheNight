/* Team 1
 * Project 2
 * controls main camera
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
   
    // Update is called once per frame
    void Update()
    {   //added so it wont follow forever ~QL
        if (CharacterControl.gameOver == !true)
        {
            transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
        }
    }
}
