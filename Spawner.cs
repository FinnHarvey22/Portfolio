using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Items;
    private int rand;
    // Start is called before the first frame update
    void Start()
    {
       rand = Random.Range(0, Items.Length);
        Instantiate(Items[rand], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
