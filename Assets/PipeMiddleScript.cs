using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public bool birdIsAlive;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && logic.birdIsAlive == true)
        {
            logic.addScore(1);
        }
          
    }
}
