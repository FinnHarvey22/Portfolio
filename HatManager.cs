using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatManager : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] hat;
    public static int Hats;


    public void Start()
    {
        spriteRenderer = GameObject.FindGameObjectWithTag("Hat").GetComponent<SpriteRenderer>();
        Hats = PlayerPrefs.GetInt("Hatss");
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        PlayerPrefs.SetInt("Hatss", Hats);
        if (Hats == 1)
        {
            spriteRenderer.sprite = hat[0];
        }
        if (Hats == 2)
        {
            spriteRenderer.sprite = hat[1];
        }
        if (Hats == 3)
        {
            spriteRenderer.sprite = hat[2];
        }
        if (Hats == 4)
        {
            spriteRenderer.sprite = hat[3];

        }
        if (Hats == 5)
        {
            spriteRenderer.sprite = hat[4];
        }
        if (Hats == 6)
        {
            spriteRenderer.sprite = hat[5];
        }
        if (Hats == 7)
        {
            spriteRenderer.sprite = hat[6];
        }
        if (Hats == 8)
        {
            spriteRenderer.sprite = hat[7];
        }
    }
    public void Hat1() 
    {
        Hats = 1;
    }
    public void Hat2()
    {
        Hats = 2;
    }
    public void Hat3()
    {
        Hats = 3;
    }
    public void Hat4()
    {
        Hats = 4;
    }
    public void Hat5()
    {
        Hats = 5;
    }
    public void Hat6()
    {
        Hats = 6;
    }
    public void Hat7()
    {
        Hats = 7;
    }
    public void Hat8()
    {
        Hats = 8;
    }
    
}
