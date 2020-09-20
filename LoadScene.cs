using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{

    public bool isLoad = false;


    void Update()
    {
        Time.timeScale = 1f;

        if (isLoad == true)
        {
            Application.LoadLevel(ButtonOpen.numberLevelForLoad);
        }
    }
}
