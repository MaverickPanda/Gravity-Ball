using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoundariesScript : MonoBehaviour
{
    public LogicScript logic;
    public BordScript bord;

    void Start ()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        bord = GameObject.FindGameObjectWithTag("Bord").GetComponent<BordScript>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (bord.scorePosted != true && logic.birdIsAlive == true)
        {
            logic.gameOver();
            bord.scorePosted = true;
        }
        
        
    }


}
