using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class flor_collision : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) 
	{
		 
		GameObject now = collision.gameObject;
//		Debug.Log ("Na podloge spadlo: " + now.name + "start pos:" + shining.startPosition);
		now.transform.position = shining.position [Cart.points];
	}

}
