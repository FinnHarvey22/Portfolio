using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectCoin : MonoBehaviour
{

    //public AudioSource collectSound;


    private void OnTriggerEnter2D(Collider2D other )
    {
        if (other.tag == "Player")
        {
            //collectSound.Play();
            ScoreSystem.theScore += 1;
            Destroy(gameObject);
            
        }
    }

} //updated 14:23 17/10  




