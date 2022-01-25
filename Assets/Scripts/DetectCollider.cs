using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollider : MonoBehaviour
{
    private int lives = 3;
    public bool gameOver;

    void Start()
    {
        gameOver = false; 
        lives = 3;
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (!gameOver)
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

    private void Gameover()
    {
        gameOver = true;
    }
}