using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class giveCoins : MonoBehaviour
   
{
    public Button exitText;
    // Start is called before the first frame update
    void Start()
    {
        exitText = exitText.GetComponent<Button>();
    }

    // Update is called once per frame
    public void GiveCoins()
    {
        ScoreSystem.theScore += 250;
    }
}
