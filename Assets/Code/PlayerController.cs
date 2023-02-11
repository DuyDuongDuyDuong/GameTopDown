using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

    public GameObject gameover;
    public bool isGameover;
    
    private Vector2 moveInput ,mouse;
    public Transform Gun;
    public Camera cam;
    
    public int maxheatl;
    public int currenHeal;
    
    public HealBar _HealBar;
    
    
    public GameObject Bullet;
    public Rigidbody2D _rigidbody2D;
    public Animator _animator;
    public float _Speed;
    public float _Hp;

    private Vector2 movevelocity;
    private float nextimefire = 0;
    public float FireTime = 2f;
  
    public Jojtick moveJoystijck;
    public Jojtick Shootjoystijck;

    [HideInInspector] public bool canShooter;
        
        
    
    
    void Start()
    {
        currenHeal = maxheatl;
        _HealBar.SetMax(maxheatl);

    }

   
    void Update()
    {
        Movement();
        Run();
        if (Input.GetMouseButton(0) && canShooter)
        {

            
            if (Time.time >= nextimefire)
            {
               
                shoot();
                nextimefire = Time.time + 1 / FireTime;


            }
            
            if (_Hp <= 0)
            {


            }
        }

        if (_Hp <= 0)
        {
           // Destroy(gameObject);
            gameover.SetActive(true);
            
            
          
        }
    }

    private void FixedUpdate()
    {
        Rotation();
    }

    void Movement()
    {
         moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
         
        if (moveJoystijck.inputDir != Vector3.zero)
        {
            moveInput = moveJoystijck.inputDir;
        }
       
         mouse = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void Rotation()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + moveInput * _Speed * Time.fixedDeltaTime);
        Vector2 lookdir = mouse - _rigidbody2D.position;
        
       // Vector2 dir = Camera.main.ScreenToViewportPoint(Input.mousePosition) - transform.position;
       
        float angle = Mathf.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg - 90f;
        _rigidbody2D.rotation = angle;
        
        if (Shootjoystijck.inputDir != Vector3.zero)
        {
            angle = Mathf.Atan2(Shootjoystijck.inputDir.y, Shootjoystijck.inputDir.x) * Mathf.Rad2Deg - 90f;
            
        }
        
        
    }

    public void shoot()
    {
        Instantiate(Bullet, Gun.position, transform.rotation);
    }

    void Run()
    {
        _animator.SetFloat("Speed", moveInput.magnitude);
    }
}
