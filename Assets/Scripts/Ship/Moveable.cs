using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveable : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 direction;

    void Awake()
    {
        direction = new Vector3();
    }

    void Update()
    {
        updatePosition();
    }

    private void updatePosition() {
        transform.position += (direction * Time.deltaTime * moveSpeed) ;
    }

    public void setDirection(Vector2 dir) {
        direction.x = dir.x;
        direction.y = dir.y;
    }

    internal Vector3 getDirection() {
        return direction;
    }

    public void setDirection(Vector3 dir) {
        direction = dir;
    }
}
