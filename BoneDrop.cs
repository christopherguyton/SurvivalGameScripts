using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MoreMountains.CorgiEngine
{
    public class BoneDrop : MonoBehaviour
    {
        private Health enemyHealth;
        private Health playerHealth;
        public GameObject boneItem;
        public GameObject healthItem;
        private int boneDrop;
        private int healthDrop;

        private static int enemyKillPoints;

        void Start()
        {
            
            enemyHealth = GetComponent<Health>();
            enemyHealth.OnDeath = DeathFunction;
            playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();

        }

        // Update is called once per frame
        void Update()
        {
           
        }   
        private void DeathFunction()
        {
            enemyKillPoints += 1; 
            boneDrop = Random.Range(1, 3);
            healthDrop = Random.Range(1, 4);
            if (boneDrop == 2) 
            {
            Instantiate(boneItem, this.transform.position, Quaternion.identity);
            } else if (playerHealth.CurrentHealth <= 40 && healthDrop == 2) 
            {
                Instantiate(healthItem, this.transform.position, Quaternion.identity);
            }
            PlayerPrefs.SetInt("EnemyDeaths", enemyKillPoints);
            

        }

        public void Reset() 
        {
            enemyKillPoints = 0;
        }

       
      
    }
}