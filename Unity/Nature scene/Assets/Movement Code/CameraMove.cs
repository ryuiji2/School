using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public float mouseH;
    public float mouseV;
    private float hor;
    private float ver;
    public float moveSpeed;


	
	void Update () {

        MouseRot();
        Movement();
	}

    void MouseRot() {

        hor += mouseH * Input.GetAxis("Mouse X");
        ver += -mouseV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(ver, hor, 0.0f);
    }
    void Movement() {
        float forwardBack = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float leftRight = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        transform.Translate(leftRight, 0, forwardBack);
    }
}
