using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BayScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float _hpBay = 3f;
    public float _dame;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {

            col.gameObject.GetComponent<PlayerController>()._Hp -= _dame;
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
