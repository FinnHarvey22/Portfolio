﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu2 : MonoBehaviour
{

    public Button exitText;

    // Use this for initialization
    void Start()
    {
         exitText = exitText.GetComponent<Button>();


    }
    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }
}
