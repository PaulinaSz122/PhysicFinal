using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTorque : MonoBehaviour {

    public Vector3 torqueAdd = new Vector3();
    Rigidbody rb;
    bool add = false;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            add = true;
        }
    }

    private void FixedUpdate()
    {
        if (add)
        {
            //rb.AddTorque(torqueAdd);
            rb.AddRelativeTorque(torqueAdd);
            add = false;
        }
    }
}
