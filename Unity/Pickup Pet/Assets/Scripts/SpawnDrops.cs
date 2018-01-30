using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDrops : MonoBehaviour {

    public GameObject pet;
    public GameObject redCube;

	void Start () {
		
	}
	
	void Update () {
        
        if (Input.GetButtonDown("use")){
            GameObject red =  Instantiate(redCube, new Vector3(1, 1, 1), Quaternion.identity);
           
        }
	}
}
