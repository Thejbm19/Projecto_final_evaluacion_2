using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float speedBullet = 5f;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate(Vector3.forward * speedBullet * Time.deltaTime);
    }
}
