using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class AutoShoot : MonoBehaviour
{
    public List<Weapon> weapons;
    public GameManagerScriptable gameManager;

    void Start()
    {
        //refreshWeapon();
    }

    void Update()
    {
        if (gameManager.isPlaying) {
            refreshWeapon();
            foreach (Weapon w in weapons) {
                if (w.gameObject.activeInHierarchy) {
                    w.shoot();
                }
            }
        }
    }

    public void refreshWeapon() {
        weapons = GetComponentsInChildren<Weapon>().ToList<Weapon>();
    }
}
