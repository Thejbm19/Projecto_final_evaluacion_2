using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float speed = 50f;
    public float turnSpeed = 50f;
    private float horizontalInput;
    private float verticalInput;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
       
        horizontalInput = Input.GetAxis("Horizontal");
       
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
       

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, gameObject.transform.rotation);
        }
    }
}
