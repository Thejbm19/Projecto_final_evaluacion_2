using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCollider : MonoBehaviour
{
    private int lives = 10;
    public GameObject flag;
    private Animator flagAnimator;
    public Vector3[] SpawnPositions;
    public GameObject enemyprefab;
    public bool endFive = false;
    public Gamemanager gamemanagerScript;

    void Start()
    {
        gamemanagerScript = FindObjectOfType<Gamemanager>();
        lives = 10;
    }  
      
     
   

    private void OnTriggerEnter(Collider otherCollider)
    {


        if (otherCollider.gameObject.CompareTag("Bala")) //Condicion de colision
        {
            Destroy(otherCollider.gameObject);
            lives--; // lives -= 1;
            if (lives <= 0)  //Si llega a zero vidas del jefe se muere
            {
                gamemanagerScript.Winning();
                Destroy(gameObject);
            }

            if (lives <= 5 && endFive == false) //si llega a 5 se spawnean enemigos
            {
                foreach (Vector3 pos in SpawnPositions)
                {
                    Instantiate(enemyprefab, pos, Quaternion.identity);
                }
                 endFive = true;
            }
        }


    }
}
