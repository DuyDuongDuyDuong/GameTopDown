using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawItem : MonoBehaviour
{
    public static SpawItem instance;
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
        yield return new WaitForSeconds(100f);
        StartCoroutine(SpawnDelay());
    }
    
    void SpawnEnemy()
    {
       
        int randomPrefabID = Random.Range(0,prefabs.Length);
        int randomSpawnPointID = Random.Range(0, spawnPoints.Length);
       var Item =  Instantiate(prefabs[randomPrefabID], spawnPoints[randomSpawnPointID].position, transform.rotation);
       Item.SetActive(true);
    }
    
    void Start()
    {
       

        StartCoroutine(WaveStartDelay());
    }

    IEnumerator WaveStartDelay()
    {
        yield return new WaitForSeconds(10f);
        GetComponent<SpawItem>().StartSpawning();
    }  
}
