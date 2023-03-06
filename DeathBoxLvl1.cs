using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBoxLvl1 : MonoBehaviour
{

    private ScoreSystem Scoring;
    private RunSystem TheRuns;
    public Animator Anim;
    public bool dead = false;

    public void Start()
    {
        Scoring = GameObject.FindGameObjectWithTag("Scores").GetComponent<ScoreSystem>();
        TheRuns = GameObject.FindGameObjectWithTag("Scores").GetComponent<RunSystem>();

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            dead = true;
            StartCoroutine(NextLevelAfterWait());
            Anim.Play("Death");
            Debug.Log("you suck, u dead");
            GameObject.Find("MOVEMENT CONTROLLER").GetComponent<Movement>().enabled = false;
            GameObject.Find("Dog").GetComponent<Jump>().enabled = false;
           
        }
       
    }
    IEnumerator NextLevelAfterWait()
    {
        Scoring.PlayerKilled();
        yield return new WaitForSeconds(1.7f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
              //updated 13:37 31/10  

// scene will load scene capture (death will add 1, so from scene 1 it will open 2) 1+1 = 2 (would you believe) for winner it  will just set to 3 (dont add, or it will add 2 every time) 