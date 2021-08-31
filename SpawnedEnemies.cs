using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MoreMountains.CorgiEngine
{
    public class SpawnedEnemies : MonoBehaviour
    {
        public GameObject[] enemiesToSpawn;
        private int enemyIndex;
        private float spawnTime = 5f;
        private float spawnTimeAdjusted = 5f;
        private GameTimer gameTimer;


        void Start() 
        {
            enemyIndex = Random.Range(0, enemiesToSpawn.Length);
            Instantiate(enemiesToSpawn[enemyIndex], this.transform.position, Quaternion.identity);
            gameTimer = FindObjectOfType<GameTimer>();
           
        }

        void Update() 
        {
            if (spawnTime > 0) 
            {
                spawnTime -= Time.deltaTime;
            }
            if (spawnTime <= 0) 
            {
                spawnTime = spawnTimeAdjusted;
                enemyIndex = Random.Range(0, enemiesToSpawn.Length);
                Instantiate(enemiesToSpawn[enemyIndex], this.transform.position, Quaternion.identity);
            }

            if (gameTimer.gameTimer == 10) 
            {
                spawnTimeAdjusted = 4.5f;
            } else if (gameTimer.gameTimer == 20) 
            {
                spawnTimeAdjusted = 4f;
            } else if (gameTimer.gameTimer == 30) 
            {
                spawnTimeAdjusted = 3.5f;
            } else if (gameTimer.gameTimer == 60) 
            {
                spawnTimeAdjusted = 2f;
            } else if (gameTimer.gameTimer == 80) 
            {
                spawnTimeAdjusted = 1.5f;
            } else if (gameTimer.gameTimer == 90) 
            {
                spawnTimeAdjusted = 1f;
            } else if (gameTimer.gameTimer == 95) 
            {
                spawnTimeAdjusted = .5f;     
            }
            
        }

  
    }

}