using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] hat;

    private void Start()
    {
        GameObject hat = GameObject.FindGameObjectWithTag("Hat");
        hat.GetComponent<HatManager>();
    }
    private void Update()
    {
       
        



    }

}