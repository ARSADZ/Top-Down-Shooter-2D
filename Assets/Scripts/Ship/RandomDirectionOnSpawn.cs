using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDirectionOnSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 dir = new Vector3();
        dir.x = Random.Range(-10f, 10f);
        dir.y = Random.Range(-10f, 10f);
        dir = dir.normalized;
        GetComponent<Moveable>().direction = dir;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
