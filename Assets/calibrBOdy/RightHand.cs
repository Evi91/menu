using UnityEngine;
using System.Collections;

public class RightHand : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider colide)
	{
		if(calibrationTrigger.rightHand.GetComponent<Renderer> ().enabled==true && colide.tag == "Rhand" && calibrationTrigger.all!=true)
			calibrationTrigger.rHand = true;
		
	}
}
