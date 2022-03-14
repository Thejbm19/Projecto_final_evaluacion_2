using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour
{
    private PlayerController PlayerScript;


    void Start()
    {
        PlayerScript = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider otherCollider)
    {

       
        if (otherCollider.gameObject.CompareTag("Player"))
        {
            PlayerScript.Gameover();
            Destroy(otherCollider.gameObject);
        }


    }
}
