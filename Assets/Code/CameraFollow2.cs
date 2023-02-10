using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{
    public float FollowSpeed;
    public Transform target;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (   FindObjectOfType<PlayerController>() != null)
        {
            Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
            transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
        }
       
    }
}
