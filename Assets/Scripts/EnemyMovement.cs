using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // start is called before the first frame update
    public float speed; 
    public Transform groundDetection; 
    private bool moveRight = true; 
    public float Raycast; 
    public float Raylength; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); 
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down,Raylength); 
        if (groundInfo.collider == false)
        {
            if (moveRight == true)
            {
                transform.eulerAngles = new Vector3(0,-180,0);
                moveRight = false; 
            } 
            else
            {
            transform.eulerAngles = new Vector3(0,0,0); 
            moveRight = true;
            }
        } 
    }
}
