using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour

{
    private bool doubleSpeed;
    private float speed = 30;
    private PlayerController playerControllerScript;
    private GameManager gM;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        gM = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }
    
    // Update is called once per frame
    void Update()
    {   
        if (!playerControllerScript.gameOver) {
            if (playerControllerScript.doubleSpeed)
            {
                transform.Translate(Vector3.left * Time.deltaTime * (speed * 2));
            }
            else
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            gM.score++;
            Debug.Log(gM.score);
            Destroy(gameObject);
        }
        
    }
}
    
    
        
   