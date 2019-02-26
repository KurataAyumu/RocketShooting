using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour {

    public GameObject Addscore;
    float fallSpeed;
    float rotSpeed;

    void Start() {
           this.fallSpeed = 0.01f + 0.1f ;
           this.rotSpeed = 1f + 3f ;
    }

    void Update() {
           transform.Translate(0, -fallSpeed, 0, Space.World);
           transform.Rotate(0, 0, rotSpeed);

           if (transform.position.y < -5f) {
                  //GameObject.Find("Canvas").GetComponent<UIController>().Gameover();
                  Destroy(gameObject);
           }
    }
}
