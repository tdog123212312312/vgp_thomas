using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 25.0f;
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      float horizontalInput = Input.GetAxis("Horizontal");
      float verticalInput = Input.GetAxis("Vertical");

      playerRb.AddForce(Vector3.forward * speed * verticalInput);
      playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    
    private void OnCollisionEnter(Collision collision)
    {
      if( collision.gameObject.CompareTag("Enemy"));
      {
          Debug.Log("Player has collided with enemy");
      }
    }

      private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PowerUp"));

        {
            Destroy(other.gameObject);
        }
    }
    

  
}
