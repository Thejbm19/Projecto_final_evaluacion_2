using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    private float startTime = 2f;
    private float repeatRate = 1.5f;
    private GameObject player;
    public GameObject PosShoot;
    private PlayerController PlayerScript;
    public float dis = 50f;
    public float range;
    private Gamemanager gameManagerScript;
    
    

    void Start()
    {
        player = GameObject.Find("Tanque");
        InvokeRepeating("shootEnemy", startTime, repeatRate);
        PlayerScript = FindObjectOfType<PlayerController>();
        gameManagerScript = FindObjectOfType<Gamemanager>();
    }

   
    void Update()
    {
        
       
        if (!PlayerScript.gameOver) //Condicion de si el player no esta muerto se ejecuta
        {
            range = Vector3.Distance(player.transform.position, transform.position);
            transform.LookAt(player.transform.position);
            
        }

        
    }

    public void shootEnemy() //Para dispara las balas
    {
        if (range <= dis && !PlayerScript.gameOver)
        {
            Instantiate(projectilePrefab, PosShoot.transform.position, gameObject.transform.rotation);
        }
    }

    
}
