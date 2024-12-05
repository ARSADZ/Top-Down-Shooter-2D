using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void spawnObject(GameObject go) {
        Vector3 randomPosition = new Vector3();
        randomPosition.x = Random.Range(-5f, 5f);
        randomPosition.y = Random.Range(-3f, 3f);

        Instantiate(go, randomPosition, go.transform.rotation);
    }
}
