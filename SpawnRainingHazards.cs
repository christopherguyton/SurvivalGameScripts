using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoreMountains.CorgiEngine
{

    public class SpawnRainingHazards : MonoBehaviour
    {
        public GameObject hazardToSpawn;
        private float spawnTime = 2f;
        private float randomSpawnTime;
        private GameTimer gameTimer;

        void Start()
        {
            gameTimer = FindObjectOfType<GameTimer>();
        }

        // Update is called once per frame
        void Update()
        {

            if (gameTimer.gameTimer > 90)
            {
                if (spawnTime > 0)
                {
                    spawnTime -= Time.deltaTime;
                }
                if (spawnTime <= 0)
                {
                    randomSpawnTime = Random.Range(1f, 6f);
                    spawnTime = randomSpawnTime;
                    Instantiate(hazardToSpawn, this.transform.position, Quaternion.identity);
                }
            }

        }
    }
}