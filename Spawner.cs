using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float time;
    public GameObject enemyPrefab;
    public float needTime;

    void Update()
    {
        time += Time.deltaTime;

        if (time > needTime) 
        {
            time = 0;
            Spawn();
        }
    }

    void Spawn()
    {
        GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);

    }
}
