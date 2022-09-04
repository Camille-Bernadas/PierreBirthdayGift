using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collider2D){
        Score.score++;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        GameManager.GetInstance().ScoreChanged(Score.score);
    }
}
