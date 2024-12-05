using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float scrollingSpeed;
    public Transform[] background;

    private Vector3 offset;
    private Vector3 direction;

    void Start()
    {
        offset = background[1].position - background[0].position;
        direction = new Vector3(0, -1, 0);
    }

    void Update()
    {
        updatePosition();

        if (background[0].transform.position.y <= -offset.y) {
            background[0].transform.position = background[1].transform.position + offset;
        }
        if (background[1].transform.position.y <= -offset.y) {
            background[1].transform.position = background[0].transform.position + offset;
        }
    }

    private void updatePosition() {
        background[0].transform.position += (direction * Time.deltaTime * scrollingSpeed);
        background[1].transform.position += (direction * Time.deltaTime * scrollingSpeed);
    }
}
