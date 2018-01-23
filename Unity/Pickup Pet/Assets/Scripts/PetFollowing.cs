using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetFollowing : MonoBehaviour {

    public GameObject player;
    public GameObject followPoint;
    public bool canPickup;
    public float speed;
	
	void Update () {
        float fast = speed * Time.deltaTime;
		if(canPickup == false) {
            transform.LookAt (followPoint.transform);
            transform.position = Vector3.MoveTowards (transform.position, followPoint.transform.position, fast);
            }
	}
}
