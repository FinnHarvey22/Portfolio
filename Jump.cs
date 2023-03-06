using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Jump : MonoBehaviour
{

    public Vector2 jumpHeight;
    bool grounded = false;
    public Animator anim;
    public DeathBoxLvl1 death;

    void Update()
    {
        anim = GetComponent<Animator>();

        if ( Input.GetKeyDown(KeyCode.Space) && grounded)  
        {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
            anim.Play("Jump");
         
        }
    }
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Ground" )
        {
            if (death.dead == false) 
            {
                anim.Play("Run");
            }
            grounded = true;
            Debug.Log("Grounded");
        }
       
    }
    void OnCollisionExit2D(Collision2D col)
    {
        grounded = false;
        Debug.Log("Not Grounded");
    }
} 

