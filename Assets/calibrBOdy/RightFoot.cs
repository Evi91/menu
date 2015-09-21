using UnityEngine;
using System.Collections;

public class RightFoot : MonoBehaviour {
	public static bool collision;
	public static bool rFoot;
	// Use this for initialization
	void Start () {
		collision = false;
		rFoot = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider colide)
	{
		if(calibrationTrigger.rightFoot.GetComponent<Renderer> ().enabled==true && colide.tag == "RFoot" && calibrationTrigger.all!=true)
			calibrationTrigger.rFoot = true;

		if (colide.tag == "RFoot" && LeftHand.collision == true) {
			collision = true;
			
		}
		/*if (collision && RightKnee.collision) {
			rFoot=!rFoot;
		}
		*/
	}


	void OnTriggerExit(Collider collide)
	{
		collision = false;
	}
}
