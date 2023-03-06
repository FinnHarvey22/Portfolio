using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RunSystem : MonoBehaviour
{
    public GameObject runText;
    public static int theRuns;
    


    private void Start()
    {
        RunSystem.theRuns += 1;
    }
    void Update()
    {
        runText.GetComponent<Text>().text = " RUNS      " + theRuns;
       
    }

    public void ResetCounter()
    {
        theRuns = 0;
    }
} //updated 15:14 18/10


