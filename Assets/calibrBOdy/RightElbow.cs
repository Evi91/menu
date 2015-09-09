using UnityEngine;
using System.Collections;

public class RightElbow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider colide)
	{
		if(calibrationTrigger.rightElbow.GetComponent<Renderer> ().enabled==true && colide.tag == "RElbow" && calibrationTrigger.all!=true)
			calibrationTrigger.rElbow = true;
		
	}
}
