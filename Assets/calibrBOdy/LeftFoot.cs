using UnityEngine;
using System.Collections;

public class LeftFoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider colide)
	{
		if(calibrationTrigger.leftFoot.GetComponent<Renderer> ().enabled==true && colide.tag == "LFoot" && calibrationTrigger.all!=true)
			calibrationTrigger.lFoot = true;
		
	}
}
