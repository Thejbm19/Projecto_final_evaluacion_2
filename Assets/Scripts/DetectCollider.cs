using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollider : MonoBehaviour
{
    private int lives = 3;
    
    void Start()
    {
        lives = 3;
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        
        
        if (otherCollider.gameObject.CompareTag("Bala"))
        {
            Destroy(otherCollider.gameObject);
            lives--; // lives -= 1;
            if (lives <= 0)
            {
                    Destroy(gameObject);
            }
               
        }

        
    }

    
}