using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    private static Pool instance;

    public int poolSize;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject boltPrefab;
    [SerializeField] private GameObject explosionPrefab;

    public List<Projectile> bullets;
    public List<Projectile> bolts;
    public List<Explosion> explosions;

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        bullets = new List<Projectile>();
        bolts = new List<Projectile>();
        explosions = new List<Explosion>();

        generateExplosions();
        generateBolts();
        generateBullets();
    }

    private void generateExplosions() {
        for (int i = 0; i < poolSize; i++) {
            GameObject go = Instantiate(explosionPrefab);
            //Explosion e = go.GetComponent<Explosion>();
            explosions.Add(go.GetComponent<Explosion>());

            go.transform.parent = this.transform;
            //go.SetActive(false);
            //e.deactivate();
        }
    }

    private void generateBullets() {
        for (int i=0;i<poolSize;i++) {
            GameObject go = Instantiate(bulletPrefab);
            //Projectile p = go.GetComponent<Projectile>();
            bullets.Add(go.GetComponent<Projectile>());

            go.transform.parent = this.transform;
            //go.SetActive(false);
            //p.deactivate();
        }
    }

    private void generateBolts() {
        for (int i = 0; i < poolSize; i++) {
            GameObject go = Instantiate(boltPrefab);
            //Projectile p = go.GetComponent<Projectile>();
            bolts.Add(go.GetComponent<Projectile>());

            go.transform.parent = this.transform;
            //go.SetActive(false);
            //p.deactivate();
        }
    }

    public Projectile getProjectile(ProjectileType type) {
        for (int i=0;i<poolSize;i++) {
            if (type == ProjectileType.BULLET) {
                if (!bullets[i].isActive()) {
                    return bullets[i];
                }
            } else if (type == ProjectileType.BOLT) {
                if (!bolts[i].isActive()) {
                    return bolts[i];
                }
            }
        }
        return null;
    }

    public Explosion getExplosion() {
        foreach(Explosion e in explosions) {
            if (!e.isActive()) {
                return e;
            }
        }
        return null;
    }

    public static Pool getInstance() {
        return instance;
    }
}
