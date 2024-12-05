using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FireRateModifier : MonoBehaviour
{
    public float modifier = 0.2f;

    private List<Weapon> weapons;

    void Start()
    {
        weapons = GetComponentsInChildren<Weapon>().ToList<Weapon>();

        foreach(Weapon w in weapons) {
            w.addFireRateModifier(modifier);
        }
    }

    private void OnDestroy() {
        foreach (Weapon w in weapons) {
            w.removeFireRateModifier(modifier);
        }
    }

    public void addComponent(GameObject go) {
        go.AddComponent<FireRateModifier>();
    }
}
