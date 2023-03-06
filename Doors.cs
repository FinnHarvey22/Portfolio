using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public GameObject door;
    public GameObject wall;
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies == null)
        {
            Debug.Log("nullllllll");
           foreach(GameObject enemies in enemies)
            {
                door.SetActive(false);
                wall.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Walls"))
        {
            Instantiate(wall, transform.position, Quaternion.identity);
        } 
        else if (collision.CompareTag("Detect"))
        {
            Instantiate(door, transform.position, Quaternion.identity);
        }
    }
}
