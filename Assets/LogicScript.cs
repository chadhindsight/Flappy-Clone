using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LogicScript : MonoBehaviour
{   
    // My solution to work around not being able to provide a parameter because ContextMenu("Increase Score") is being used
    public int scoreToAdd;
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
         playerScore = playerScore + scoreToAdd;
    // Can remove these logs later
    Debug.Log("Player score: " + playerScore);
    Debug.Log("scoreText.text: " + scoreText.text);
    scoreText.text = playerScore.ToString();
    Debug.Log("scoreText.text updated to: " + scoreText.text);
        
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }



}