using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    public Vector3[] spawnPositions;
    public GameObject enemyprefab;
    public GameObject jefeprefab;
    public int totalEnemies;
    public Vector3 jefepos = new Vector3(0, 11.34f, 110.5f);
    public TextMeshProUGUI enemiesNumber;
    private int enemyNumber = 0;

    void Start()
    {
         foreach(Vector3 pos in spawnPositions)
         {
             Instantiate(enemyprefab, pos, Quaternion.identity);
             totalEnemies++;
         }

        enemiesNumber.text = totalEnemies.ToString();
      
    }

    

    void Update()
    {
        if(totalEnemies <= 0)
        {
            Instantiate(jefeprefab, jefepos, jefeprefab.transform.rotation);
        }
    }

    public void EnemyKilled()
    {
        totalEnemies--;
        enemiesNumber.text = totalEnemies.ToString();
    }

}
