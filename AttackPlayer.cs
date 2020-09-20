using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    public string animationAttack;

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<Animator>().Play(animationAttack);
        }
    }
}
