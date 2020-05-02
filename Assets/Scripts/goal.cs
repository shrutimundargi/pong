using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    public bool isPlayer1Goal;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pong"))
        {
            if (isPlayer1Goal)
            {
                Debug.Log("Player 2 Scored");
                GameObject.Find("GameObject").GetComponent<manager>().Player2Scored();
            }

            else
            {
                Debug.Log("Player 1 Scored");
                GameObject.Find("GameObject").GetComponent<manager>().Player1Scored();
            }
        }
       
    }
}
