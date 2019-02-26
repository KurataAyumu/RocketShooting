using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGenerator : MonoBehaviour {

    public GameObject RockPrefab;

    void Start() {
            InvokeRepeating("GenRock", 1, 1);
    }

    void GenRock() {
            Instantiate(RockPrefab, new Vector3(-3f + (7 * Random.value), 5, 0), Quaternion.identity);
    }
}
