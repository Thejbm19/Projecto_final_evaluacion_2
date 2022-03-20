using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    public Vector3[] spawnPositions;
    public GameObject enemyprefab;
    public GameObject jefeprefab;
    private int totalEnemies;
    public Vector3 jefepos = new Vector3(0, 11.34f, 110.5f);
    public TextMeshProUGUI enemiesNumber;
    private int enemyNumber = 0;
    public bool isBossSpawned;
    public GameObject winPanel;
    public GameObject losePanel;


    void Start()
    {
         foreach(Vector3 pos in spawnPositions)
         {
             Instantiate(enemyprefab, pos, Quaternion.identity);
             totalEnemies++;
         }

       
        enemiesNumber.text = totalEnemies.ToString();
      

    }



  

    public void EnemyKilled()
    {
        if (isBossSpawned == false)
        {
            totalEnemies--;
            enemiesNumber.text = totalEnemies.ToString();
            if (totalEnemies <= 0)
            {
                Instantiate(jefeprefab, jefepos, jefeprefab.transform.rotation);
                isBossSpawned = true;
            }
        }
    }

    public void Winning()
    {
        winPanel.SetActive(true);
    }

    public void Losing()
    {
        losePanel.SetActive(true);
    }

}
