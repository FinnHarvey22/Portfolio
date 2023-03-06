using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    private GameObject scoreText;
    public static int theScore;
    public static int scoreAmount;
    public static int CoinsLostOnDeath = 3;

  void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("ScoreText");
        theScore = PlayerPrefs.GetInt(" COINS:      ");
    }
    void Update()
    {
        scoreText.GetComponent<Text>().text = " COINS:      " + theScore;
        DontDestroyOnLoad(this.gameObject);
        theScore += scoreAmount;
        LoadCoins();
    }


    public void PlayerKilled()
    {
        ScoreSystem.theScore -= 3;
        Debug.Log("you lost 3 coins");

        if(ScoreSystem.theScore <= 0)
        {
            ScoreSystem.theScore = 0;
        }
    }
   public void LoadCoins() 
    {
        PlayerPrefs.SetInt(" COINS:      ", theScore);
    }

   

    }     //updated 14:23 17/10  
