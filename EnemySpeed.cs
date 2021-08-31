using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoreMountains.CorgiEngine
{



    public class EnemySpeed : CharacterAbility
    {
        private GameTimer gameTimer;
        public CharacterHorizontalMovement characterHorizontalMovement;

        void Awake() 
       {
            gameTimer = FindObjectOfType<GameTimer>();
            
        }
        void Update() 
        {
            
            if (gameTimer.gameTimer >= 30) 
            {
                base.Initialization();
                characterHorizontalMovement.MovementSpeed = 3f;
            } else if (gameTimer.gameTimer >= 60) {
             base.Initialization();
                characterHorizontalMovement.MovementSpeed = 4f;
                
            } else if (gameTimer.gameTimer >= 90) {
              base.Initialization();
                characterHorizontalMovement.MovementSpeed = 5f;
            }
        }
    }

}
