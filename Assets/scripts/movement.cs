using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float speed = 10;
    float thrust = 20;
    Rigidbody2D rigid;

	// Use this for initialization
	void Start ()
    {
        rigid = GameObject.Find("sleepyGhost").GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
       
	}
    private void FixedUpdate()
    {
        Moving();
    }

    void Moving()
    {
        float transition = Input.GetAxis("Horizontal") * speed;
        //float straffe = Input.GetAxis("Vertical") * speed;  // no flying! TOO TIRED or GETTING SKILL LATER
        transition *= Time.deltaTime;
        //straffe *= Time.deltaTime;
        transform.Translate(transition, /*straffe*/ 0, 0);
    }
}
