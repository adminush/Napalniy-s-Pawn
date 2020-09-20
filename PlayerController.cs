using System.Collections;
using System.Collections.Specialized;
using UnityEngine;

[RequireComponent (typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float lookSpeed = 5f;

    public float bullets = 40;

    public GameObject pause;
    public GameObject iconGun;
    public GameObject pause2;
    public GameObject GameUI;

    public bool gunSwitch = false;
    public GameObject guner;

    public GameObject gun1;
    public GameObject gun1Sp;
    public GameObject gun2;

    public string animationAttack;

    float xMov;
    float zMov;
    float yRot;
    float xRot;

    private PlayerMotor motor;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MedKit")
        {
            ScoreControll.hp += 45;
        }

        if (collision.gameObject.tag == "BulletScore")
        {
            ScoreControll.bullets += 20;
        }

        if (collision.gameObject.tag == "Boost")
        {
            speed += 2f;
        }

        if (collision.gameObject.tag == "Enemy")
        {
            ScoreControll.hp -= 15;
        }

        if (collision.gameObject.tag == "Enemy2")
        {
            ScoreControll.hp -= 25;
        }

        if (collision.gameObject.tag == "Gun")
        {
            gunSwitch = true;
            iconGun.SetActive(true);
        }
    }

    void Start()
    {
        UnityEngine.Cursor.visible = false;
        motor = GetComponent<PlayerMotor>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause.SetActive(true);
            UnityEngine.Cursor.visible = true;
        }


        if (Input.GetKeyDown(KeyCode.Alpha1) && gunSwitch == true)
        {
            gun1.SetActive(true);
            gun1Sp.SetActive(true);
            gun2.SetActive(false);
        } else if (Input.GetKeyDown(KeyCode.Alpha2) && gunSwitch == true) 
        {
            gun1.SetActive(false);
            gun1Sp.SetActive(false);
            gun2.SetActive(true);
        }

        if (ScoreControll.hp <= 0)
        {
            Destroy(this);
            Destroy(gameObject.GetComponent("Shooting"));
            Destroy(gameObject.GetComponent("AttackPlayer"));
            Destroy(guner);
            UnityEngine.Cursor.visible = true;
            pause2.SetActive(true);
        }

        yRot = Input.GetAxisRaw("Mouse X");
        xRot = Input.GetAxisRaw("Mouse Y");

        xMov = Input.GetAxisRaw("Horizontal");
        zMov = Input.GetAxisRaw("Vertical");

        Vector3 rotation = new Vector3(0f, yRot, 0f) * lookSpeed;
        Vector3 camRotation = new Vector3(xRot, 0f, 0f) * lookSpeed;

        Vector3 movHorizontal = transform.right * xMov;
        Vector3 movVertical = transform.forward * zMov;

        Vector3 velocity = (movHorizontal + movVertical).normalized * speed;

        motor.CamRotate(camRotation);
        motor.Rotate(rotation);
        motor.Move(velocity);
    }
}
