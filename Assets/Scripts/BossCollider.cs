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


        if (otherCollider.gameObject.CompareTag("Bala"))
        {
            Destroy(otherCollider.gameObject);
            lives--; // lives -= 1;
            if (lives <= 0)
            {
                gamemanagerScript.Winning();
                Destroy(gameObject);
            }

            if (lives <= 5 && endFive == false)
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
