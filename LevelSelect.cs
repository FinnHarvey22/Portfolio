using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public Button Level1;
    public Button Level2;
    public Button Level3;
    public Button Level4;
    public Button Level5;
    public Button Menu;
    
    void Start()
    {
        Level1 = Level1.GetComponent<Button>();
        Level2 = Level2.GetComponent<Button>();
        Level3 = Level3.GetComponent<Button>();
        Level4 = Level4.GetComponent<Button>();
        Level5 = Level5.GetComponent<Button>();
        Menu = Menu.GetComponent<Button>();
    }

    public void Select1() 
    {
        SceneManager.LoadScene(2);
    }
    public void Select2()
    {
        SceneManager.LoadScene(5);
    }
    public void Select3()
    {
        SceneManager.LoadScene(8);
    }
    public void Select4()
    {
        SceneManager.LoadScene(11);
    }
    public void Select5()
    {
        SceneManager.LoadScene(14);
    }

    public void SelectMenu()
    {
        SceneManager.LoadScene(0);
    }

}
