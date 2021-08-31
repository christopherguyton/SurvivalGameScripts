using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalPoints : MonoBehaviour
{
    public Text FinalPointsText;
    public Text FinalTimerText;

    public Text FinalEnemyKills;
    void Start()
    {
        FinalPointsText.text = "Bones Collected " + PlayerPrefs.GetInt("FinalPoints").ToString();
        FinalTimerText.text = "You Survived " + PlayerPrefs.GetInt("TimeSurvived").ToString() + " Seconds!";
        FinalEnemyKills.text = "Enemies Killed " + PlayerPrefs.GetInt("EnemyDeaths").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
