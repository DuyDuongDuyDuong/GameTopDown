using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScriptt : MonoBehaviour
{ 
    public static int _DameHit = 1;
    private Rigidbody2D _rigidbody2D;
    [SerializeField] public float _Speed;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 3f);

    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody2D.velocity = transform.up * _Speed;
        
        
       
       
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            col.gameObject.GetComponent<EnemyScript>()._Hp -= _DameHit;
            Destroy(gameObject);
           Scout3._Sconre += 1;
           
        
           if (Scout3._Sconre == 5 )
           {
               LvScript.Lv += 1;
               _DameHit += 1;
          
           }
           else if (Scout3._Sconre == 10)
           {
               LvScript.Lv += 1;
               _DameHit += 1;
              
           }
           else if (Scout3._Sconre == 15)
           {
               LvScript.Lv += 1;
               _DameHit += 1;
           }
           
               
           

           
           
        }
        if (col.CompareTag("bay"))
        {
           col.gameObject.GetComponent<BayScript>()._hpBay -=_DameHit;
           Destroy(gameObject);
          

        }
        
     
    }
}
