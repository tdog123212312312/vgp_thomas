using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    private AudioSource playerAudio;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    public AudioClip crashSound2;
    public bool doubleSpeed = false;
    private GameManager gM;
    //private float Speed_Multiplier123;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
        gM = GameObject.Find("GameManager").GetComponent<GameManager>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        { 
            dirtParticle.Stop();
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig"); 
            playerAudio.PlayOneShot(jumpSound, 1.0f);

        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
        doubleSpeed = true;
        playerAnim.SetFloat("Speed_Multiplier" , 2.0f);
        } 
        else if (doubleSpeed)
        {
        doubleSpeed = false;
        playerAnim.SetFloat("Speed_Multiplier", 1.0f);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            dirtParticle.Play();
            isOnGround = true;
            Debug.Log("Still Playing");
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            dirtParticle.Stop();
            Debug.Log("Game Over");
            Debug.Log("Final Score: " + gM.score);
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            playerAudio.PlayOneShot(crashSound, 1.0f);
            playerAudio.PlayOneShot(crashSound2, 1.0f);
        
           
    
        }
    }
}

