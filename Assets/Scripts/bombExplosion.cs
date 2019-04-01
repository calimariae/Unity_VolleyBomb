using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombExplosion : MonoBehaviour
{
    public bombTimer bombTimer;

    public GameObject bomb;

    // Lydklipp
    public AudioSource bombSound1;
    public AudioClip bombHitWall;

    public AudioSource bombSound2;
    public AudioClip bombHitHead;

    Animator anim;
    public bool exploded;

    private void Start()
    {
        bombSound1.clip = bombHitWall;
        bombSound2.clip = bombHitHead;
        anim = GetComponent<Animator>();
    }

    IEnumerator destroyBomb()
    {
        yield return new WaitForSeconds(2);
     // |   Destroy(bomb);
        exploded = true;
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            bombSound2.Play();
        }
        else
        {
            bombSound1.Play();
        };
        
    }

    void Update()
    {


    }

    public void explosion(int state)
    {
        if(state == 1)
        {
            print("kaboom");
            if (!exploded)
            {
                anim.SetInteger("exploded", 0);
            }
            anim.SetInteger("exploded", 1);
            StartCoroutine(destroyBomb());
        }
    }
}
