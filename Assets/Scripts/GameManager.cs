using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    public Text ScoreMenutext;
    void Start()
    {
        score = 0;
        ScoreText.text = score.ToString();
       
    }

    void Update()
    {
        
    }
   
  public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }
    public void UpdateScoreMenu()
    {
        ScoreMenutext.text = "sa";

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void ScoreButton()
    {      
        SceneManager.LoadScene(2);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
