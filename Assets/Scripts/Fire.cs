using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
       public Transform LaunchOffset;

    public fxControl bullet;

    public float reloadTime;

    public float spawnTime;

    public bool isSpawned;

 

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, reloadTime);
        
    }

      public void SpawnObject()
    {
        Instantiate(bullet, LaunchOffset.position, transform.rotation);
        if (isSpawned)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
