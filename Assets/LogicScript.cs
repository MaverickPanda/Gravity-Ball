using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
  
  public Text ScoreText;
  public GameObject gameOverScreen;
  public GameObject Score;
  public Text FinalScoreText;
  public bool birdIsAlive;
  public Text bestScoreText;
  public static class ScoreStorage
  {
    public static int playerScore {get; set;}
    public static int lastScore {get; set;}
    public static int bestScore {get; set;}
    public static bool bestScoreEmpty {get; set;}
  }
  public bool lastScoreEmpty = true;
  public AudioSource backgroundMusic;
  public static bool musicPlaying;


  void Start()
  {
    birdIsAlive = true;
    print(ScoreStorage.bestScoreEmpty);
    if (lastScoreEmpty == false)
    {
      ScoreStorage.lastScore = ScoreStorage.playerScore;
    }
    else
    {
      ScoreStorage.lastScore = 0;
    }
    ScoreStorage.playerScore = 0;

    if (ScoreStorage.bestScoreEmpty == true)
    {
      ScoreStorage.bestScore = 0;
      Debug.Log("best score reset");
    }
    //print("starting best score:" + ScoreStorage.bestScore);
    if (musicPlaying == false)
    {
      backgroundMusic.Play();
      musicPlaying = true;
    }
  }  

[ContextMenu("Increase Score")]
  public void addScore(int scoreToAdd)
  {
    ScoreStorage.playerScore += scoreToAdd;
    ScoreText.text = ScoreStorage.playerScore.ToString();
    Debug.Log("Score Updated");
  }

  public void restartGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void gameOver()
  {
    gameOverScreen.SetActive(true);
    Score.SetActive(false);
    FinalScoreText.text = ScoreStorage.playerScore.ToString();
    birdIsAlive = false;
    lastScoreEmpty = false;
    ScoreStorage.bestScoreEmpty = false;
    
    if (ScoreStorage.playerScore > ScoreStorage.bestScore)
    {
      bestScoreText.text = ScoreStorage.playerScore.ToString();
      ScoreStorage.bestScore = ScoreStorage.playerScore;
      Debug.Log("new best");
    }
    if (ScoreStorage.playerScore <= ScoreStorage.bestScore)
    {
      bestScoreText.text = ScoreStorage.bestScore.ToString();
      Debug.Log("old best");
    }
    DontDestroyOnLoad(backgroundMusic);
    print("ending best score:" + ScoreStorage.bestScore);
  }
}
