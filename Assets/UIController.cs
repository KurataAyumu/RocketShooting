using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour{

    int score = 0;
    GameObject ScoreText;
    GameObject gameOverText;

    public void Gameover(){
           gameOverText.GetComponent<Text>().text = "Gameover";
    }

    public void AddScore(){
           score += 10;
    }

    // Use this for initialization
    void Start(){
          this.ScoreText = GameObject.Find("Score");
          this.gameOverText = GameObject.Find("Gameover");
    }

    void Update(){
        ScoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
    }
}