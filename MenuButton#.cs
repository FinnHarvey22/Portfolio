using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public Sprite ButtonNotPressed;
    public Sprite ButtonPressed;
    public GameObject Exit;
    public GameObject Start;
    public SpriteRenderer Button1;
    public SpriteRenderer Button2;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButton() 
    {
        Button1.sprite = ButtonPressed;

    }
    public void ExitButton()
    {
        Button2.sprite = ButtonPressed;
    }
}
