using UnityEngine;
using System.Collections;

public class RightKnee : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider colide)
	{
		if(calibrationTrigger.rightKnee.GetComponent<Renderer> ().enabled==true && colide.tag == "RKnee" && calibrationTrigger.all!=true)
			calibrationTrigger.rKnee = true;
		
	}
}
