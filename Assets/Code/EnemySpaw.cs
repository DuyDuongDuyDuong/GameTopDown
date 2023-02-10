using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = System.Random;

public class EnemySpaw : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform[] spawnPoints;
    public int amout = 10;
    public float rate = 5f;
    private float _time;


    private void Update()
    {
        // if ( prefabs != null)
        // {
        if (_time < 0)
        {
            Spaw();
            _time = rate;
        }

        _time -= Time.deltaTime;
        // }
    }

    void Spaw()
    {
        if (amout < 0)
        {
            return;
        }

        int randomSpawnPointID = UnityEngine.Random.Range(0, spawnPoints.Length);
          int randomPrefabID =UnityEngine. Random.Range(0,prefabs.Length);
        
        
        
        var zombie = Instantiate(prefabs[randomPrefabID], spawnPoints[randomSpawnPointID].position, quaternion.identity);
        zombie.SetActive(true);
        
    }
}