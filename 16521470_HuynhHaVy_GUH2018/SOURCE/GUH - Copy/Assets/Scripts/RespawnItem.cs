using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RespawnItem : MonoBehaviour {
    private GameObject prefab;
    public GameObject[] enemyPrefabs;
    float Timer=0f, WinTime=0f;
    // Use this for initialization
    
    void Start() {

       // for (int i = 0; i < numEnemies; i++)
        //{
            //SpawnEnemy();
        //}
    }
    private void SpawnEnemy()
    {
        int rnd = Random.Range(0, 4);
        Vector3 newPos = new Vector3(Random.Range(-5, 5), 6, 0);
        Instantiate(enemyPrefabs[rnd], newPos, Quaternion.identity);
    }
    //public int numEnemies = 30;
    private float spawnCooldown = 2f;
    private float timeUntilSpawn = 1.75f;
    // Update is called once per frame
    void Update()
    {
        Timer++;
        WinTime++;
        if (Timer == 4 * 60)
        {
            spawnCooldown /= 1.25f;
            Timer = 0;
        }
        if (WinTime == 35*60)
        {
            SceneManager.LoadScene("WinMenu");
        }

        timeUntilSpawn -= Time.deltaTime;
        if (timeUntilSpawn < 0)
        {
            // Do your enemy spawns here
            SpawnEnemy();
            // Reset for next spawn
            timeUntilSpawn = spawnCooldown;
        }

    }
}
