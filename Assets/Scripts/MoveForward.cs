using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float speedBullet = 10f;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate(Vector3.forward * speedBullet * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Bala_Enemy"))
        {
            
            Destroy(otherCollider.gameObject);
        }

    }
}
