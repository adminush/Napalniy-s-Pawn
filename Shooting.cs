using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePos;
    public GameObject bulletPrefab;
    public int damage;
    public float time;
    public AudioSource coinSound;
    bool selectTime = false;

    public int numberGun;

    void Update()
    {
        if(numberGun == 1) 
        { 
            if (time >= 0.4f && selectTime != false)
            {
                gameObject.GetComponent<Collider>().enabled = false;
                selectTime = false;
                time = 0f;
            }

            if (selectTime == true)
            {
                time += Time.deltaTime;

            }

            if (Input.GetButtonDown("Fire1"))
            {
                selectTime = true;
                gameObject.GetComponent<Collider>().enabled = true;
                coinSound.Play();
            }
        } else if(numberGun == 2) 
        {
            if (Input.GetButtonDown("Fire1") && ScoreControll.bullets > 0)
            {
                Shoot();
                coinSound.Play();
                ScoreControll.bullets--;
            }
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePos.position, firePos.rotation);
    }
}
