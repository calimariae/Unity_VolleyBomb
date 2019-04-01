using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathZoneCollider : MonoBehaviour
{

    public scoreScript _text;


    void OnTriggerEnter2D(Collider2D other)
    {
        _text.addScore(1);

    }
}
