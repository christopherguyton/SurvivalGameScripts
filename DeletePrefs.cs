using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MoreMountains.CorgiEngine {

public class DeletePrefs : MonoBehaviour
{
        private GameManager gameManager;
        private BoneDrop resetKills;

        void Start() 
        {
            gameManager = FindObjectOfType<GameManager>();
            resetKills = FindObjectOfType<BoneDrop>();

        }
        public void DeleteSaves()
    {
        PlayerPrefs.DeleteAll();
            gameManager.SetPoints(0);
            resetKills.Reset();

        }

    public void QuitGame() {
        Application.Quit();
    }
}
}
