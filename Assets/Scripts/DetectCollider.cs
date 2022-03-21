using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollider : MonoBehaviour
{
    private int lives = 1;
    public Gamemanager gamemanagerscript;
    
    void Start()
    {
        lives = 1;
        gamemanagerscript = FindObjectOfType<Gamemanager>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        
        
        if (otherCollider.gameObject.CompareTag("Bala")) //Condicion de si bala es golpeado o golpea
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