using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour
{
    private PlayerController PlayerScript;


    void Start()
    {
        PlayerScript = FindObjectOfType<PlayerController>(); //Conectar scripts
    }

    
    void Update()
    {

    }

    private void OnTriggerEnter(Collider otherCollider)
    {

       
        if (otherCollider.gameObject.CompareTag("Player")) //Condicion de colision entre bala y player
        {
            PlayerScript.Gameover();
            Destroy(otherCollider.gameObject);
        }


    }
}
