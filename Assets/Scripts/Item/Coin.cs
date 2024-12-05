using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue;
    public ScriptableInteger coin;
    public GameObject coinPrefab;

    void Start()
    {
        
    }

    public void coinGain() {
        coin.value += coinValue;
    }

    public void coinSpawn() {
        Instantiate(coinPrefab, transform.position, Quaternion.identity);
    }
}
