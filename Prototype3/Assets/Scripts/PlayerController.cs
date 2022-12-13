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

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        { 
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        } 

         
    }
     private void OnCollisionEnter(Collision collision)
        {
            

            if(collision.gameObject.CompareTag("Ground"))

        {
            isOnGround = true;

        } else if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over You Suck Take The L Loser");
            gameOver = true;
            playerAnim.SetBool("Death_")
        }
        }
}
