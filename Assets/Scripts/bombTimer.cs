using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bombTimer : MonoBehaviour
{
    public bombExplosion bombExplosion;
    public Text timer;

    Animator anim;

    int timeLeft = 120;
    public float countdown;

    // Use this for initialization
    void Start()
    {

        //  bombtext.text = "Tick tack: " + countdown;

    }

    // Update is called once per frame
    void Update()
    {
        countdown = timeLeft - Time.timeSinceLevelLoad;
        //   setMeshTest();
        //   print(countdown);
        setBombTimer();
    }


    public void setMeshTest()
    {

        GetComponent<TextMesh>().text = "" + countdown.ToString("F0");
    }

    void setBombTimer()
    {
        if (countdown > 1)
        {
            timer.text = "Boom: " + countdown.ToString("F0");
        }
        else
        {
            timer.text = "KABOOM!";
            bombExplosion.explosion(1);
        }


    }


    public void GameOver()
    {
     //   GetComponent<TextMesh>().text = "TEST";
    }
}

