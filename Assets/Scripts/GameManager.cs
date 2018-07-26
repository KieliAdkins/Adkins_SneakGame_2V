using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    // Declaring the variables
    public static GameManager instance;
    public int playerLives;
    public Text scoreText;
    public int playerScore;

    // Use this for initialization and destruction of duplicate Game Managers
    void Awake()
    {
        // Ensuring that the Game manager is loaded
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        // Ensuring that the Game manager is not overwritten
        else
        {
            Destroy(this.gameObject);
        } 
    }

    // Update function
    private void Update()
    {
        // Calling the Score Text function
        SetScoreText(); 
    }

    // Score Text function
    void SetScoreText()
    {
        // Setting the score text to display the player's score
        scoreText.text = "Score: " + playerScore.ToString();
    }


  
}
