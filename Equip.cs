using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip : MonoBehaviour
{


    public GameObject[] EquipButtons;



    public Shop shop;




// Start is called before the first frame update
    void Start()
    {


     
    }

    // Update is called once per frame
    void Update()
    {
        if (shop.Hat0 == 1)
        {
            EquipButtons[0].SetActive(true);
            Debug.Log("Hat0");
        }


        if (shop.Hat1 == 1)
        {
            EquipButtons[1].SetActive(true);
            Debug.Log("Hat1");
        }


        if (shop.Hat2 == 1)
        {
            EquipButtons[2].SetActive(true);
            Debug.Log("Hat2");
        }


        if (shop.Hat3 == 1)
        {
            EquipButtons[3].SetActive(true);
            Debug.Log("Hat3");
        }


        if (shop.Hat4 == 1)
        {
            EquipButtons[4].SetActive(true);
            Debug.Log("Hat4");
        }


        if (shop.Hat5 == 1)
        {
            EquipButtons[5].SetActive(true);
            Debug.Log("Hat5");
        }


        if (shop.Hat6 == 1)
        {
            EquipButtons[6].SetActive(true);
            Debug.Log("Hat6");
        }


        if (shop.Hat7 == 1)
        {
            EquipButtons[7].SetActive(true);
            Debug.Log("Hat7");
        }
    }
    void loadHats()
    {
        
    }
}
