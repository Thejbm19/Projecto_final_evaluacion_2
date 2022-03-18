using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollider : MonoBehaviour
{
    private int lives = 3;
    public Gamemanager gamemanagerscript;
    
    void Start()
    {
        lives = 3;
        gamemanagerscript = FindObjectOfType<Gamemanager>();
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
                gamemanagerscript.EnemyKilled();
                    Destroy(gameObject);
            }
               
        }

        
    }

    
}