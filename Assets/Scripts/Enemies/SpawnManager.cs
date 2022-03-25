using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] zombiePrefabs;
    private float SpawnRangeX = 10f;
    private float SpawnRangeZ = 10f;
    private float startDelay =  2;
    private float spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnZombie",  startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        SpawnZombie();
    }

    void SpawnZombie()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Vector3 spawnPos = new Vector3(
                500 + Random.Range(-SpawnRangeX, SpawnRangeZ),
                0, 500 + Random.Range(-SpawnRangeZ, SpawnRangeZ));
            int zombieIndex = Random.Range(0, zombiePrefabs.Length);
            Instantiate(zombiePrefabs[zombieIndex], spawnPos, transform.rotation);
        }
    }
}
