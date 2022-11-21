using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePerfab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repatRate = 2;
     // Start is called before the first frame update
    void Start()
    {
            InvokeRepeating("SpawnObstacle", startDelay, repatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle ()
    {
             Instantiate(obstaclePerfab, spawnPos, obstaclePerfab.transform.rotation);
    }
    
}
