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
    private float zRange = -22f;
    public bool gameOver;
    public ParticleSystem explosionParticleSystem;
    public AudioClip deathClip;
    private AudioSource cameraAudioSource;
    public bool shootLimit;
    public Gamemanager gamemanagerScript;





    void Start()
    {
        gameOver = false;
        cameraAudioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        shootLimit = true;
        gamemanagerScript = FindObjectOfType<Gamemanager>();

    }

    // Update is called once per frame
    void Update()
    {

        if (!gameOver)
        {
            verticalInput = Input.GetAxis("Vertical");
            horizontalInput = Input.GetAxis("Horizontal");

            transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        }

        if (Input.GetKey(KeyCode.Space) && shootLimit)
        {
            Instantiate(projectilePrefab, disparoPos.transform.position, gameObject.transform.rotation);
            StartCoroutine(shootLimits());
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }


    }

    public void Gameover()
    {
        gamemanagerScript.Losing();
        gameOver = true;
        explosionParticleSystem = Instantiate(explosionParticleSystem, transform.position, transform.rotation);
        explosionParticleSystem.Play();
        cameraAudioSource.PlayOneShot(deathClip, 1);

    }

    public IEnumerator shootLimits()
    {
        shootLimit = false;
        yield return new  WaitForSeconds(0.5f);
        shootLimit = true;

    }

    
}
