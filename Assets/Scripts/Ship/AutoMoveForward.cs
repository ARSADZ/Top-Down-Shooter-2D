using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class AutoMoveForward : MonoBehaviour
{
    private Moveable moveable;

    void Start()
    {
        moveable = GetComponent<Moveable>();
    }

    void Update() {
        moveable.setDirection(transform.up);
    }
}
