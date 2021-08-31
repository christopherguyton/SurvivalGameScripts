using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MoreMountains.CorgiEngine
{


    public class PauseTest : MonoBehaviour
    {
        private GameManager gameManager;
        void Start()
        {
            gameManager = FindObjectOfType<GameManager>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.JoystickButton7)) 
            {
                PauseGame();
            }
        }

        void PauseGame() 
        {
            gameManager.Pause();
        }
    }
}
