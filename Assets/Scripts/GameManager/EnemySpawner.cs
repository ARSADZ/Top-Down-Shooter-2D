using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemySpawner : MonoBehaviour
{
    public int level = 1;
    public GameManagerScriptable gameManager;
    public List<ObjectSpawnRate> enemyPrefabs;
    public List<GameObject> enemies;

    private float timer = 0;

    void Start()
    {
        enemies = new List<GameObject>();
    }

    void Update()
    {
        if (gameManager.isPlaying) {
            if (timer > getSpawnTimer()) {
                spawn();
                timer = 0;
            }

            timer += Time.deltaTime;
        }
    }

    public void spawn() {
        //clearEmptyEnemyList();

        GameObject go = Instantiate(getEnemyType());
        go.transform.position = getRandomPosition();

        enemies.Add(go);

        level++;
    }

    private void clearEmptyEnemyList() {
        enemies.RemoveAll(go => go == null);
    }

    private GameObject getEnemyType() {
        int limit = 0;
        foreach(ObjectSpawnRate osr in enemyPrefabs) {
            limit += osr.rate;
        }
        int random = UnityEngine.Random.Range(0, limit);

        //Debug.Log("random number " + random);

        int i = 0;
        foreach (ObjectSpawnRate osr in enemyPrefabs) {
            if (random < osr.rate) {
                break;
            } else {
                random = random - osr.rate;
            }
            i++;
        }
        //Debug.Log("object spawned " + enemyPrefabs[i].prefab.name);

        return enemyPrefabs[i].prefab;
    }

    private Vector3 getRandomPosition() {
        Vector3 position = transform.position;
        float range = transform.localScale.x / 2;
        position.x = UnityEngine.Random.Range(-range, range);

        return position;
    }

    private float getSpawnTimer() {
        float t = 5;
        return t / (1 + ((float)level / 17f));
    }

    public void resetValue() {
        level = 1;
        timer = 0;

        removeAllEnemies();
    }

    private void removeAllEnemies() {
        clearEmptyEnemyList();

        foreach(GameObject go in enemies) {
            Destroy(go);
        }

        clearEmptyEnemyList();
    }

    private void OnEnable() {
        gameManager.retryAction += resetValue;
    }

    private void OnDisable() {
        gameManager.retryAction -= resetValue;
    }
}
