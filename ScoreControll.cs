using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControll : MonoBehaviour
{

    public static int score;
    public static int score2;
    public static int hp;
    public static int bullets;

    public Text scoreText;
    public Text scoreText2;
    public Text hpText;
    public Text bulletText;

    void Start()
    {
        scoreText = GetComponent<Text>();
        score = 0;
        score2 = 0;
        hp = 100;
        bullets = 40;
    }

    void Update()
    {
        scoreText.text = score + "";
        scoreText2.text = score2 + "";
        hpText.text = hp + "";
        bulletText.text = bullets + "";
    }
}
