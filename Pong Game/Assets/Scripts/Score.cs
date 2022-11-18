using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int player1Score = 0;
    public int player2Score = 0;
    public Text p1Text;
    public Text p2Text;
    public GameObject Challenge;

    private bool SpawnChallenge = true;

    public void AddP1Score()
    {
        player1Score++;
        p1Text.text = player1Score.ToString();
    }
    public void AddP2Score()
    {
        player2Score++;
        p2Text.text = player2Score.ToString();
    }

    public void Player1Wins()
    {
        SceneManager.LoadScene("Player1Wins");
    }
    public void Player2Wins()
    {
        SceneManager.LoadScene("Player2Wins");
    }

    public void Update()
    {
        if (player1Score == 10)
        {
            Player1Wins();
        }

        if (player2Score == 10)
        {
            Player2Wins();
        }
    }


}