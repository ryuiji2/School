using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    Transform playerTrans;

	void Start () {
        StartCoroutine (moving ());
        }
	
	void Update () {

        Rotation();
	}
    void Rotation () {

        if (Input.GetButtonDown ("w")) {
            transform.eulerAngles = new Vector3 (0, 0, 0);
            }
        if (Input.GetButtonDown ("a")) {
            transform.eulerAngles = new Vector3 (0, -90, 0);
            }
        if (Input.GetButtonDown ("d")) {
            transform.eulerAngles = new Vector3 (0, 90, 0);
            }
        if (Input.GetButtonDown ("s")) {
            transform.eulerAngles = new Vector3 (0, -180, 0);
            }
        }

    IEnumerator moving() {
        transform.position += transform.forward;
        yield return new WaitForSeconds (0.3f);
        StartCoroutine (moving ());
        }
}
