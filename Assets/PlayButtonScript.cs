using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
    public Scene MainGame;

    public void Start()
    {
        
    }
    public void startGame()
    {
        SceneManager.LoadScene(MainGame.name);
        Debug.Log("scene signal");
    }
}
