using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ProjectileType {
    BULLET, BOLT
}
public class Weapon : MonoBehaviour
{
    public ProjectileType projectileType;
    public float fireRate;
    public List<float> fireRateModifiers;

    private float delay;

    void Start()
    {
        fireRateModifiers = new List<float>();

        delay = 0;
    }

    void Update()
    {
        //delay update
        delay = delay - Time.deltaTime < 0 ? 0 : delay - Time.deltaTime;
    }

    public void shoot() {
        if (delay <= 0) {
            Pool.getInstance().getProjectile(projectileType).activate(transform.position, transform.rotation, transform.up);

            delay = fireRate / getFireRateModifier();
        }
    }

    private float getFireRateModifier() {
        float modifier = 1;

        foreach(float f in fireRateModifiers) {
            modifier += f;
        }

        return modifier;
    }

    public void addFireRateModifier(float value) {
        fireRateModifiers.Add(value);
    }

    public void removeFireRateModifier(float value) {
        fireRateModifiers.Remove(value);
    }
}
