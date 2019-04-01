using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataCollector : MonoBehaviour {

    public deathAreaPlayer deathArea1;
    public deathAreaPlayer deathArea2;

    public bool a1;
    public bool a2;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
        a1 = deathArea1.inArea;
        a2 = deathArea2.inArea;
    }
}
