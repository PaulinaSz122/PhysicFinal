using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    Vector3 up = new Vector3(0, 9.81f, 0);
    Vector3 down = new Vector3(0, -9.81f, 0);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump"))
        {
            Physics.gravity = up;
        }
        if (Input.GetButtonUp("Jump"))
        {
            Physics.gravity = down;
        }
	}
}
