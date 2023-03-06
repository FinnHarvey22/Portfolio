using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsOpen : MonoBehaviour
{
    public GameObject Settingsmenu;
    public Button Open;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OpenMenu()
    {
        
        
            Settingsmenu.SetActive(true);
            //Time.timeScale = 0f;
            //GameObject.Find("Dog").GetComponent<Jump>().enabled = false;
            //GameObject.Find("MOVEMENT CONTROLLER").GetComponent<Movement>().enabled = false;
            //GameObject.Find("Dog").GetComponent<Animator>().enabled = false;
        

    }

} //updated 14:04 07/12/2022
