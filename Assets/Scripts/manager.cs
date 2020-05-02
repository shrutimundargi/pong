using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class manager : MonoBehaviour
{
    [Header("Pong")]
    public GameObject pong;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject p1score;
    public GameObject p2score;

    private int Player1Score;
    private int Player2Score;
    public void Player1Scored()
    {
        Player1Score++;
        p1score.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }

    // Update is called once per frame
    public void Player2Scored()
    {
        Player2Score++;
        p2score.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }

    void ResetPosition()
    {
        pong.GetComponent<ball>().Reset();
        player1Paddle.GetComponent<movement>().Reset();
        player2Paddle.GetComponent<movement>().Reset();
    }
}
