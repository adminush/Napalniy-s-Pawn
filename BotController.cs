using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotController : MonoBehaviour
{
    public Transform playerTr;

    public GameObject deadSound;

    public bool enemy2;

    public float speed;

    void Start() 
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerTr = player.transform;
    }

    private void OnCollisionEnter(Collision _colEnt)
    {
        if (_colEnt.gameObject.tag == "Knife" || _colEnt.gameObject.tag == "Bullet")
        {
            GameObject sound = Instantiate(deadSound, gameObject.transform.position, gameObject.transform.rotation);
            
            if(enemy2 == true) 
            {
                ScoreControll.score2++;
            } else
            {
                ScoreControll.score++;
            }

            Destroy(gameObject);
        }
    }

    void Update() 
    {
        transform.position = Vector3.Lerp(transform.position, playerTr.position, speed * Time.deltaTime);
        transform.LookAt(playerTr);
    }
}
