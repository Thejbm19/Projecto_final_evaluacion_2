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
    
    

    void Start()
    {
        player = GameObject.Find("Tanque");
        InvokeRepeating("shootEnemy", startTime, repeatRate);
        PlayerScript = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!PlayerScript.gameOver)
        {
            transform.LookAt(player.transform.position);
        }  
    }

    public void shootEnemy()
    {
        Instantiate(projectilePrefab, PosShoot.transform.position, gameObject.transform.rotation);
    }

}
