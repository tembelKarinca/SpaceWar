using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    public int count =0; 
    public Transform parent;
    public GameObject enemyBoss;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (count<5 && !enemyBoss.activeSelf)
        {
            int randomEnemy=Random.Range(0,enemyPrefabs.Length);
            int randomSpawnPoint = Random.Range(0,spawnPoints.Length);

            Instantiate(enemyPrefabs[0], spawnPoints[randomSpawnPoint].position,transform.rotation).transform.SetParent(parent);
            count++;
        }
        
    }
}
 