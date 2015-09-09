using UnityEngine;
using System.Collections;

public class RightFoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider colide)
	{
		if(calibrationTrigger.rightFoot.GetComponent<Renderer> ().enabled==true && colide.tag == "RFoot" && calibrationTrigger.all!=true)
			calibrationTrigger.rFoot = true;
		
	}
}
