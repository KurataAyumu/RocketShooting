using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController2 : MonoBehaviour {

    public GameObject RocketController1;
    public GameObject bulletPrefab;

        void Update(){
               if(Input.GetKeyDown(KeyCode.Space)){
                     Instantiate(bulletPrefab, transform.position, Quaternion.identity);
               }

        }
}
