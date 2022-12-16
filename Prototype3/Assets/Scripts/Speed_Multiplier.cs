using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Multiplier : MonoBehaviour
{
    private float Speed_Multiplier123;
    private bool doubleSpeed;
    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.LeftShift))
            {
                doubleSpeed = true;
                playerAnim.SetFloat("Speed_Multiplier123", 2.0f);
                Debug.Log("Left Shift Was Pressed");
            }
            else if (!Input.GetKey(KeyCode.LeftShift))
            {
                doubleSpeed = false;
                playerAnim.SetFloat("Speed_Multiplier123", 1.0f);
                Debug.Log("Left Shift Was Not Pressed");
            }  
  
    }
}
