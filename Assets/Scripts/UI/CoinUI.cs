using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUI : MonoBehaviour
{
    public ScriptableInteger coin;

    private Text text;

    void Start() {
        text = GetComponent<Text>();
    }

    void Update()
    {
        if (coin) {
            text.text = coin.value.ToString();
        }
    }
}
