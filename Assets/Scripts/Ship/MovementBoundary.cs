using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBoundary : MonoBehaviour
{
    public Rect boundary;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nextPosition().x < boundary.xMin || nextPosition().x > boundary.xMax) {
            GetComponent<Moveable>().direction.x = 0;
        }
        if (nextPosition().y < boundary.yMin || nextPosition().y > boundary.yMax) {
            GetComponent<Moveable>().direction.y = 0;
        }
    }

    private Vector2 nextPosition() {
        Vector3 pos = GetComponent<Moveable>().direction + transform.position;
        Vector2 nextPos = pos;

        return nextPos;
    }
}
