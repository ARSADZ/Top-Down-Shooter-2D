using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffect : MonoBehaviour
{
    void Start()
    {
        
    }

    public void showExplosion() {
        Pool.getInstance().getExplosion().activate(transform.position);
    }
}
