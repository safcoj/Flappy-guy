using System.Collections.Generic;
using UnityEngine;

public class TubeSpawner : MonoBehaviour
{
    public GameObject towerPrefabOne;
    public GameObject towerPrefabTwo;
    public GameObject towerPrefabThree;
    public float spawnRate = 1.5f;
    public float heightRange = 2f;

    private float timer;


    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnTube();
            timer = 0f;
        }
    }

    void SpawnTube()
    {
        List<GameObject> towerPrefabs = new List<GameObject>() {
            towerPrefabOne,
            towerPrefabTwo,
            towerPrefabThree,
        };


        int randomTower = Random.Range(0, 3);
        float randomY = Random.Range(-heightRange, heightRange);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, 0f);

        Instantiate(towerPrefabs[randomTower], spawnPosition, Quaternion.identity);
    }
}
