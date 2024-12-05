using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class Projectile : MonoBehaviour
{
    private float travelDistance = 0;

    void Start()
    {
        deactivate();
    }

    private void Update() {
        //distance update
        travelDistance += (Time.deltaTime * GetComponent<Moveable>().direction * GetComponent<Moveable>().moveSpeed).magnitude;
        
        if (travelDistance > 30f) {
            deactivate();
        }
    }

    public void activate(Vector3 position, Quaternion rotation, Vector3 direction) {
        gameObject.SetActive(true);

        travelDistance = 0;
        transform.position = position;
        transform.rotation = rotation;
        GetComponent<Moveable>().setDirection(direction);
    }

    public void deactivate() {
        gameObject.SetActive(false);
    }

    internal bool isActive() {
        return gameObject.activeInHierarchy;
    }

    public void OnTrigger() {
        Pool.getInstance().getExplosion().activate(transform.position);
    }
}
