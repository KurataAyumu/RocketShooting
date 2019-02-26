using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverGameSystem : MonoBehaviour {

    public void Gameover() {
            SceneManager.LoadScene("Game");
        }
    }
