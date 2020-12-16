using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager1 : MonoBehaviour
{
    public GameObject[] enemy;
    private int enemyIndex;
    private Vector3 spawnPos;
    private int spawnRange =19;
    private int spawnPosZ = 10;
    private float delayTime = 0.5f;
    private float rate = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy",delayTime,rate);
    }

    // Update is called once per frame
    void Update()
    {
             
    }
    void SpawnEnemy()
    {
        enemyIndex = Random.Range(0, enemy.Length);
        spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 0, spawnPosZ);
        Instantiate(enemy[enemyIndex], spawnPos, transform.rotation);
        
    }
}
