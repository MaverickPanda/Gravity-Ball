using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BordScript : MonoBehaviour
{
    public Rigidbody2D MyRigidbody;
    public float FlapStrength;
    public LogicScript logic;
    public bool scorePosted;
    

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        scorePosted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && logic.birdIsAlive == true)
        {
            MyRigidbody.linearVelocity = Vector2.down * FlapStrength;  //Vector2.up = shorthand for (0,1)
        }
        MyRigidbody.gravityScale -= 0.001f * Time.deltaTime;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (scorePosted != true && logic.birdIsAlive == true)
        {
            logic.gameOver();
            scorePosted = true;
        }
        
    }

    
}
