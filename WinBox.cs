using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class WinBox : MonoBehaviour
{
    public RunSystem TheRuns;
    public Animation Anim;

     void Start()
    {
        Anim = gameObject.GetComponent<Animation>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Winner")
        {
            StartCoroutine(NextLevelAfterWait());
            Anim.Play("Win Animation");
            Debug.Log("nice");
            GameObject.Find("MOVEMENT CONTROLLER").GetComponent<Movement>().enabled = false;
            GameObject.Find("Dog").GetComponent<Jump>().enabled = false;
            TheRuns.ResetCounter();
            
        }
    }
    IEnumerator NextLevelAfterWait()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}                //updated 15:14 18/10