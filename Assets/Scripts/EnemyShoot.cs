using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    private float startTime = 2f;
    private float repeatRate = 1.5f;
    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Tanque");
        InvokeRepeating("shootEnemy", startTime, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
    }

    public void shootEnemy()
    {
        Instantiate(projectilePrefab, transform.position, gameObject.transform.rotation);
    }

    

}
