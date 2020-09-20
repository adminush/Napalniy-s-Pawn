using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perk : MonoBehaviour
{
    public GameObject down;
    public float needTime;

    public bool gunOrNot;
    public int numberGun;

    private float time;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            down.SetActive(false);
            gameObject.GetComponent<BoxCollider>().enabled = false;
            time = 0;

            if(gunOrNot == true) 
            { 
            
            }
        }
    }

    void Update() 
    {
        time += Time.deltaTime;

        if(time > needTime) 
        {
            down.SetActive(true);
            gameObject.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
