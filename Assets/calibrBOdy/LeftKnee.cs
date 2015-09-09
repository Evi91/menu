using UnityEngine;
using System.Collections;

public class LeftKnee : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider colide)
	{
		if(calibrationTrigger.leftKnee.GetComponent<Renderer> ().enabled==true && colide.tag == "LKnee" && calibrationTrigger.all!=true)
			calibrationTrigger.lKnee = true;
		
	}
}
