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
    public bool isBossSpawned;
    public GameObject winPanel;
    public GameObject losePanel;


    void Start()
    {
         foreach(Vector3 pos in spawnPositions) //Bucle para instanciar las torretas en posiciones especificas
         {
             Instantiate(enemyprefab, pos, Quaternion.identity);
             totalEnemies++;
         }

       
        enemiesNumber.text = totalEnemies.ToString();
      

    }



  

    public void EnemyKilled() //Funcion para determinar si el enemigo esta "Muerto" se ejecutan unas acciones
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

    public void Winning() //Funcion de ganar
    {
        winPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Losing() //Funcion que te muestra fin del juego en texto
    {
        losePanel.SetActive(true);
    }

}
