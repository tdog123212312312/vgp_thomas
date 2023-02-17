using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;

    private float zEnemySpawn = 25.4432f;
    private float yEnemySpawn = -0.00326097f;
    private float xEnemySpawn = 9.729782f;
    
    private float xSpawnRange = 16.0f;
    private float xPowerupRange = 5.0f;
    private float zPowerupRange = 5.0f;
    private float ySpawn = 0.75f;

    private float powerupSpawnTime = 5.0f;
    private float enemySpawnTime = 1.0f;
    private float startDelay = 1.0f;
    
    // Start is called before the first frame update
    void Start()
     {
        InvokeRepeating("SpawnRandomEnemy", startDelay, enemySpawnTime);
        InvokeRepeating("spawnPowerup", startDelay, powerupSpawnTime);
     }

    // Update is called once per frame
    void Update()
   {

   }

     

    void SpawnRandomEnemy()
     {
         float randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(xEnemySpawn, yEnemySpawn, zEnemySpawn);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
     }

    void SpawnPowerup()
     {
         float randomX = Random.Range(-xSpawnRange, xSpawnRange);
         float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

         Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);

         Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
     }
}
