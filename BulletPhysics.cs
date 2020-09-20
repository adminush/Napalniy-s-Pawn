using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletPhysics : MonoBehaviour
{
    public GameObject hitEffect;
    public Transform forward;
    public float speed;
    public int damage;

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, forward.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }
}

