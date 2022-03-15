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
    public GameObject disparoPos;
    private float xRange = 7.5f;
    private float xRAnge = -7.5f;
    public bool gameOver;
    public ParticleSystem explosionParticleSystem;
    public AudioClip deathClip;
    private AudioSource cameraAudioSource;
    




    void Start()
    {
        gameOver = false;
        cameraAudioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        


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
            Instantiate(projectilePrefab, disparoPos.transform.position, gameObject.transform.rotation);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x < xRAnge)
        {
            transform.position = new Vector3(xRAnge, transform.position.y, transform.position.z);
        }

       
    }

    public void Gameover()
    {
        gameOver = true;
        explosionParticleSystem = Instantiate(explosionParticleSystem, transform.position, transform.rotation);  
        explosionParticleSystem.Play();
        cameraAudioSource.PlayOneShot(deathClip, 1);

    }

    
}
