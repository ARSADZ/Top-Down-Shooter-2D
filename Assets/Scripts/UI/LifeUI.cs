using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeUI : MonoBehaviour
{
    public ScriptableInteger life;
    public ScriptableInteger maxLife;
    public List<GameObject> lifeIcons;

    void Start()
    {
        
    }

    void Update()
    {
        showLife();
    }

    private void showLife() {
        for(int i=0;i<maxLife.value;i++) {
            if (i < life.value) lifeIcons[i].SetActive(true);
            else lifeIcons[i].SetActive(false);
        }
    }
}
