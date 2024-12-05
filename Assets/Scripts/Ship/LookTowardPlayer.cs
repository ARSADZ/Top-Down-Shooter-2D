using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(Rotateable))]
public class LookTowardPlayer : MonoBehaviour {
    public GameManagerScriptable gameManager;

    void Start() {

    }

    void Update() {
        if (gameManager.playerObject != null) {
            GetComponent<Rotateable>().lookAt(gameManager.playerObject.transform.position - transform.position);
        }
    }
}
