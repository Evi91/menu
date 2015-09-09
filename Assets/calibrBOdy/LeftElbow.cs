using UnityEngine;
using System.Collections;

public class LeftElbow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider colide)
	{
		if(calibrationTrigger.leftElbow.GetComponent<Renderer> ().enabled==true && colide.tag == "LElbow" && calibrationTrigger.all!=true)
			calibrationTrigger.lElbow = true;
		
	}
}
