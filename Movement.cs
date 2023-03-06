using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    void Update()
    {

        transform.Translate(+speed, 0, 0);

    }
 
} //updated 14:02 12/10


