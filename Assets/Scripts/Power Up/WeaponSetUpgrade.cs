using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSetUpgrade : MonoBehaviour
{
    void Start()
    {
        
    }

    public void addComponent(GameObject go) {
        go.AddComponent<WeaponSetUpgrade>();
    }
}
