using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainItem : MonoBehaviour
{
    public List<ObjectSpawnRate> itemList;


    void Start()
    {
        
    }

    public void instantiateItems() {
        GameObject go = getItem();

        if (go != null) 
            Instantiate(go, transform.position, go.transform.rotation);
    }

    private GameObject getItem() {
        int limit = 0;
        foreach(ObjectSpawnRate osr in itemList) {
            limit += osr.rate;
        }

        int random = Random.Range(0, limit);

        int i = 0;
        foreach (ObjectSpawnRate osr in itemList) {
            if (random < osr.rate) {
                break;
            } else {
                random -= osr.rate;
            }
            i++;
        }

        return itemList[i].prefab;
    }
}
