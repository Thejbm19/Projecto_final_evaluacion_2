using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    private float speedBullet = 5f;
    
    

   
    void Update()
    {
        transform.Translate(Vector3.forward * speedBullet * Time.deltaTime); // Movimiento de la bala
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Bala_Enemy"))
        {
            
            Destroy(otherCollider.gameObject);
        }

    }
}
