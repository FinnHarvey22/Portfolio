using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    //public SpriteRenderer Button;
    public Sprite ButtonPressed;
    public Sprite ButtonNotPressed;
    public Image Button;



    public void OnPointerEnter(PointerEventData eventData)
    {
        Button.sprite = ButtonPressed;
    }
 
        public void OnPointerExit(PointerEventData eventData) 
    {
        Button.sprite = ButtonNotPressed;
    }

    public void Hover()
    {
        Button.sprite = ButtonPressed;
    }

    public void NotHover() 
    {
        
        Button.sprite = ButtonNotPressed;
    }
    public void Levels() 
    {
        SceneManager.LoadScene(1);
    }
    public void quit() 
    {
        Application.Quit();
    }

}
