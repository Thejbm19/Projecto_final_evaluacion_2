using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public Vector3[] spawnPositions;
    public GameObject enemyprefab;
    public GameObject jefeprefab;
    public int totalEnemies;
    public Vector3 jefepos = new Vector3(0, 11.34f, 110.5f);

    void Start()
    {
         foreach(Vector3 pos in spawnPositions)
         {
             Instantiate(enemyprefab, pos, Quaternion.identity);
             totalEnemies++;
         }

      
    }

    

    void Update()
    {
        if(totalEnemies <= 0)
        {
            Instantiate(jefeprefab, jefepos, jefeprefab.transform.rotation);
        }
    }

    
}
