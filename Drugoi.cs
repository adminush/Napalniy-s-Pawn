using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drugoi : MonoBehaviour
{
    public GameObject main;

    void Update()
    {
        gameObject.transform.position = main.transform.position;
        gameObject.transform.rotation = main.transform.rotation;
    }
}
