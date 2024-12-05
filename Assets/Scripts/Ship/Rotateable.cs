using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotateable : MonoBehaviour
{
    public Vector3 rotationDirection;
    public float rotationSpeed;

    void Start()
    {
        rotationDirection = new Vector3();
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (rotationDirection * Time.deltaTime * rotationSpeed));
    }

    internal void lookAt(Vector3 offset) {
        transform.up = offset;
    }
}
