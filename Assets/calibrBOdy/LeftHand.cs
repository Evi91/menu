using UnityEngine;
using System.Collections;

public class LeftHand : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider colide)
	{

		if (calibrationTrigger.leftHand.GetComponent<Renderer> ().enabled == true && colide.tag == "Lhand" && calibrationTrigger.all!=true) {

			calibrationTrigger.lHand = true;
		}
	}
}
