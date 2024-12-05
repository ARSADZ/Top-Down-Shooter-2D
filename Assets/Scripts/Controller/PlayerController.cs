using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class PlayerController : MonoBehaviour
{
    public InputHandler inputHandler;
    public GameManagerScriptable gameManager;

    private Moveable moveable;

    void Start()
    {
        gameManager.playerObject = gameObject;
    }

    void Update()
    {

    }

    private void OnEnable() {
        moveable = GetComponent<Moveable>();

        inputHandler.actionOnMove += moveable.setDirection;
    }

    private void OnDisable() {
        inputHandler.actionOnMove -= moveable.setDirection;
    }
}
