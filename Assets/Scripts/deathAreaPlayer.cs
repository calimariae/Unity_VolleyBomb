using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathAreaPlayer : MonoBehaviour
{
    public bombExplosion bombExplosion;
    public bombTimer bombTimer;
    public bool inArea;

    public string da;

    void Start()
    {
        da = this.gameObject.ToString();
       // print(this.gameObject.ToString());
    }

    // Bomba er i spillersone
    void OnTriggerEnter2D(Collider2D other)
    {
        inArea = true;

        if(bombTimer.countdown < 2 && inArea)
        {
            print("FIRE IN THE HOLE!");
        }
    }

// Bomba forlater spillersona
    void OnTriggerExit2D(Collider2D collision)
    {
        inArea = false;
    }

    void reportGameobject()
    {
    
    }
}
