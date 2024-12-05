using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionTowardPlayer : MonoBehaviour
{
    public GameManagerScriptable gameManager;

    void Start() {
        GetComponent<Moveable>().direction = (gameManager.playerObject.transform.position - transform.position).normalized;
    }

    void Update()
    {
    }
}
