using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSetController : MonoBehaviour
{
    public List<GameObject> weaponSet;

    void Start()
    {

    }

    void Update()
    {
        weaponSetCheck();
    }

    private void weaponSetCheck() {
        for (int i = 0; i < weaponSet.Count; i++) {
            if (getWeaponSetUpgradeCount() == i) {
                weaponSet[i].SetActive(true);
            }
            else {
                weaponSet[i].SetActive(false);
            }
        }
    }

    private int getWeaponSetUpgradeCount() {
        return GetComponents<WeaponSetUpgrade>().Length > weaponSet.Count-1 ? weaponSet.Count-1 : GetComponents<WeaponSetUpgrade>().Length;
    }
}
