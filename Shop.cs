using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    private ScoreSystem Scoring;
    public static int Hats;
    public GameObject[] Buttons;
    public HatManager hatManager;
    public bool[] hatBought;

    public int Hat0;
    public int Hat1;
    public int Hat2;
    public int Hat3;
    public int Hat4;
    public int Hat5;
    public int Hat6;
    public int Hat7;

    //public GameObject EquipButtons0;
    //public GameObject EquipButtons1;
    //public GameObject EquipButtons2;
    //public GameObject EquipButtons3;
    //public GameObject EquipButtons4;
    //public GameObject EquipButtons5;
    //public GameObject EquipButtons6;
    //public GameObject EquipButtons7;



    private void Start()
    {
        Hat0 = PlayerPrefs.GetInt("Hat0");
        Hat1 = PlayerPrefs.GetInt("Hat1");
        Hat2 = PlayerPrefs.GetInt("Hat2");
        Hat3 = PlayerPrefs.GetInt("Hat3");
        Hat4 = PlayerPrefs.GetInt("Hat4");
        Hat5 = PlayerPrefs.GetInt("Hat5");
        Hat6 = PlayerPrefs.GetInt("Hat6");
        Hat7 = PlayerPrefs.GetInt("Hat7");
        Scoring = GameObject.FindGameObjectWithTag("Scores").GetComponent<ScoreSystem>();



        if (Hat0 != 0)
        {
            Destroy(Buttons[0]);
        }
        if (Hat1 != 0)
        {
            Destroy(Buttons[1]);
        }
        if (Hat2 != 0)
        {
            Destroy(Buttons[2]);
        }
        if (Hat3 != 0)
        {
            Destroy(Buttons[3]);
        }
        if (Hat4 != 0)
        {
            Destroy(Buttons[4]);
        }
        if (Hat5 != 0)
        {
            Destroy(Buttons[5]);
        }
        if (Hat6 != 0)
        {
            Destroy(Buttons[6]);
        }
        if (Hat7 != 0)
        {
            Destroy(Buttons[7]);
        }
        Debug.Log(Hat0);
        Debug.Log(Hat1);
        Debug.Log(Hat2);
        Debug.Log(Hat3);
        Debug.Log(Hat4);
        Debug.Log(Hat5);
        Debug.Log(Hat6);
        Debug.Log(Hat7);
    }

    void Update()
    {
        loadHats();
        //controls the shop buttons  
        if (ScoreSystem.theScore >= 25)
        {
            Buttons[0].gameObject.SetActive(true);
            Buttons[1].gameObject.SetActive(true);

        }
        if (ScoreSystem.theScore < 25)
        {

            Buttons[0].gameObject.SetActive(false);
            Buttons[1].gameObject.SetActive(false);
        }

            if (ScoreSystem.theScore >= 50)
            {
            Buttons[2].gameObject.SetActive(true);
            Buttons[3].gameObject.SetActive(true);
            }
            if (ScoreSystem.theScore < 50)
            {
            Buttons[2].gameObject.SetActive(false);
            Buttons[3].gameObject.SetActive(false);
            }

            if (ScoreSystem.theScore >= 75)
            {
            Buttons[4].gameObject.SetActive(true);
            Buttons[5].gameObject.SetActive(true);
            }
            if (ScoreSystem.theScore < 75)
            {
            Buttons[4].gameObject.SetActive(false);
            Buttons[5].gameObject.SetActive(false);
            }

        if (ScoreSystem.theScore >= 100)
        {
            Buttons[6].gameObject.SetActive(true);
            Buttons[7].gameObject.SetActive(true);
        }
            if (ScoreSystem.theScore < 100)
            {
            Buttons[6].gameObject.SetActive(false);
            Buttons[7].gameObject.SetActive(false);
            }
        
    //controls the equip buttons
        
        

    }
    public void Buy1()
    {
        ScoreSystem.theScore -= 25;
        //Shop.Hats = 1;
        Destroy(Buttons[0]);
        Hat0 = 1;
    }
    public void Buy2()
    {
        ScoreSystem.theScore -= 25;
        // Shop.Hats = 2;
        Destroy(Buttons[1]);
        Hat1 = 1;
    }
    public void Buy3()
    {
        ScoreSystem.theScore -= 50;
        //Shop.Hats = 3;
        Destroy(Buttons[2]);
        Hat2 = 1;
    }
    public void Buy4()
    {
        ScoreSystem.theScore -= 50;
        //Shop.Hats = 4;
        Destroy(Buttons[3]);

        Hat3 = 1;

    }
    public void Buy5()
    {
        ScoreSystem.theScore -= 75;
        //Shop.Hats = 5;
        Destroy(Buttons[4]);
        Hat4 = 1;

    }
    public void Buy6()
    {
        ScoreSystem.theScore -= 75;
        //Shop.Hats = 6;
        Destroy(Buttons[5]);
        Hat5 = 1;

    }
    public void Buy7()
    {
        ScoreSystem.theScore -= 100;
        //Shop.Hats = 7;
        Destroy(Buttons[6]);
        Hat6 = 1;

    }
    public void Buy8()
    {
        ScoreSystem.theScore -= 100;
        //Shop.Hats = 8;
        Destroy(Buttons[7]);
        Hat7 = 1;

    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    
        foreach (GameObject Buttons in Buttons)
        {
            gameObject.SetActive(false);
        }
    }

    public void equip0()
    {
        hatManager.Hat1();

    }
    public void equip1()
    {
        hatManager.Hat2();

    }
    public void equip2()
    {
        hatManager.Hat3();

    }
    public void equip3()
    {
        hatManager.Hat4();

    }
    public void equip4()
    {
        hatManager.Hat5();

    }
    public void equip5()
    {
        hatManager.Hat6();

    }
    public void equip6()
    {
        hatManager.Hat7();

    }
    public void equip7()
    {
        hatManager.Hat8();

    }
    public void reset()
    {
        Hat0 = 0;
        Hat1 = 0;
        Hat2 = 0;
        Hat3 = 0;
        Hat4 = 0;
        Hat5 = 0;
        Hat6 = 0;
        Hat7 = 0;

    }

    public void loadHats()
    {
        PlayerPrefs.SetInt("Hat0", Hat0);
        PlayerPrefs.SetInt("Hat1", Hat1);
        PlayerPrefs.SetInt("Hat2", Hat2);
        PlayerPrefs.SetInt("Hat3", Hat3);
        PlayerPrefs.SetInt("Hat4", Hat4);
        PlayerPrefs.SetInt("Hat5", Hat5);
        PlayerPrefs.SetInt("Hat6", Hat6);
        PlayerPrefs.SetInt("Hat7", Hat7);
    }


    //this script took me two weeks, it made me want to d*e multiple times



}
    




