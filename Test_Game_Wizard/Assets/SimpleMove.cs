using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour {

    public GameObject obj;
    public float range = 5f;
    public float moveSpeed = 3f, turnSpeed = 40f;

		
	// Update is called once per frame
	void Update () {
        
        if ((Input.GetKey(KeyCode.UpArrow))|| (Input.GetKey(KeyCode.W)))
            obj.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow) || (Input.GetKey(KeyCode.S)))
            obj.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
            obj.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
            obj.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);


    }
}
