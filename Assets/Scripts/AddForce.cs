using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour {

    public Vector3 forceAdd = new Vector3();
    Rigidbody rb;
    bool add = false;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump"))
        {
            add = true;
        }
	}

    private void FixedUpdate()
    {
        if (add)
        {
            // rb.AddForce(forceAdd);
            rb.AddRelativeForce(forceAdd);
            add = false;
        }
    }
}
