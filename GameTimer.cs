using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace MoreMountains.CorgiEngine
{


    public class GameTimer : MonoBehaviour
    {
        public float gameTimer;
        public bool gameIsRunning;
        public Text GameTimerText;
        private Health playerHealth;
        private GameManager gameManager;
        void Start()
        {
        StartGameTimer();
        playerHealth.OnDeath = gameOverFunction;
        gameManager = FindObjectOfType<GameManager>();
        
        }
        void StartGameTimer()
        {
           playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();

            if (gameTimer >= 0)
            {
                gameIsRunning = true;
                GameTimerText.text = gameTimer.ToString("f0");
                gameTimer++;
                Invoke("StartGameTimer", 1.0f);
            }
            
        }

        void gameOverFunction()
        {
            StartCoroutine("deathSequence");
            int finalGameTimer = (int) Mathf.Round(gameTimer);
            PlayerPrefs.SetInt("FinalPoints", gameManager.Points);
            PlayerPrefs.SetInt("TimeSurvived", finalGameTimer);
            gameManager.SetPoints(0);
        }

        IEnumerator deathSequence() 
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }

    }

}