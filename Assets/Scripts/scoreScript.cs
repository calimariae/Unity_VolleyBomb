using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public deathZoneCollider _deathzone;
    public Text score;
    public int currentScore;


    // Use this for initialization
    void Start()
    {

        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SetScoreText();
    }

    void SetScoreText()
    {
        score.text = "Poeng: " + currentScore;
    }

    public void addScore(int scoreAmount)
    {
        currentScore = currentScore + scoreAmount;
    }

}