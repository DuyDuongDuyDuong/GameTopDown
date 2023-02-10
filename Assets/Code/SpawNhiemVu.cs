using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawNhiemVu : MonoBehaviour
{
    public static SpawNhiemVu instance;
    void Awake(){instance=this;}
    
    public GameObject[] prefabs;
    public Transform[] spawnPoints;
   
    
    
    public void StartSpawning()
    {
        StartCoroutine(SpawnDelay());
    }
    
    public IEnumerator SpawnDelay()
    {
        SpawnEnemy();
        yield return new WaitForSeconds(8f);
        StartCoroutine(SpawnDelay());
    }
    
    void SpawnEnemy()
    {
       
        int randomPrefabID = Random.Range(0,prefabs.Length);
        int randomSpawnPointID = Random.Range(0, spawnPoints.Length);
         var NV = Instantiate(prefabs[randomPrefabID], spawnPoints[randomSpawnPointID].position, transform.rotation);
         NV.SetActive(true);
    }
    
    void Start()
    {
       

        StartCoroutine(WaveStartDelay());
    }

    IEnumerator WaveStartDelay()
    {
        yield return new WaitForSeconds(10f);
        StartSpawning();
    }  
}
