using System;
using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;
using Random = System.Random;

public class EnemyScript : Protitles
{

    public int _Dame, _Hp;
    private Rigidbody2D _rigidbody2D;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
     

    }
    
    void Update()
    {
        if (_Hp <= 0 && gameObject != null)
        {
            Destroy(gameObject);
        }

    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            col.gameObject.GetComponent<PlayerController>()._Hp -= _Dame;
            col.gameObject.GetComponent<PlayerController>().currenHeal -= _Dame;
            col.gameObject.GetComponent<PlayerController>()._HealBar.SetHeat(col.gameObject.GetComponent<PlayerController>().currenHeal);
        }

    }

  
}
