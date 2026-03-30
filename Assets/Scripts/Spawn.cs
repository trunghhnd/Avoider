using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int poolSize = 10;
    public float spawnRate = 1.5f;
    public float rangeX = 7f;
    List<GameObject> enemyPool;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        enemyPool = new List<GameObject>();
        for(int i=0; i< poolSize; i++)
        {
            GameObject obj = Instantiate(enemyPrefab);
            obj.SetActive(false);
            enemyPool.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>= spawnRate)
        {
            SpawnEnemy();
            timer = 0f;
            spawnRate = Mathf.Max(0.5f, spawnRate - 0.01f);
        }
    }
    void SpawnEnemy()
    {
        foreach(GameObject obj in enemyPool)
        {
            if (!obj.activeInHierarchy)
            {
                float X = Random.Range(-rangeX, rangeX);
                Vector3 spawnPos = new Vector3(X, 5f, 0);
                obj.transform.position = spawnPos;
                obj.SetActive(true);
                break;
            }
        }
    }
}
