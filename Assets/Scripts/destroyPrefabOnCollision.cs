using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPrefabOnCollision : MonoBehaviour {

    public GameObject destroyOnHit;
    
    public AudioSource hitSoundSource;
    public AudioClip hitSoundClip;

    public GameObject prefab;

    public float particlePositionx;
    public float particlePositiony;

    // Use this for initialization
    void Start () {
        hitSoundSource.clip = hitSoundClip;
	}
	
	// Update is called once per frame
	void Update () {
		
        
	}

    // Destroy gameobject, play destroy sound and instantiate destroy particle prefab
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(destroyOnHit);
        hitSoundSource.Play();
        Instantiate(prefab);
        print(prefab + "Destroyed");
    }
}
