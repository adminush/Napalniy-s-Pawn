using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBefor : MonoBehaviour
{

	public GameObject befor;
	public GameObject start;

	public bool yes;

    void FixedUpdate()
    {
        if(yes == true) 
        {
        	start.SetActive(true);
        	befor.SetActive(false);
        }
    }
}
