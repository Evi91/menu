using UnityEngine;
using System.Collections;

public class RightKnee : MonoBehaviour {
	public static bool collision;
	// Use this for initialization
	void Start () {
		collision = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider colide)
	{
		if(calibrationTrigger.rightKnee.GetComponent<Renderer> ().enabled==true && colide.tag == "RKnee" && calibrationTrigger.all!=true)
			calibrationTrigger.rKnee = true;
		
		if (colide.tag == "RKnee") {
			collision = true;
			
			
		}
		//else 
			//collision = false;
	

		
	}
	void OnTriggerStay(Collider colide)
	{
		if (colide.tag == "RKnee" && gameObject.GetComponent<Renderer> ().enabled == true) {
			collision = true;
			//Debug.Log ("Kolizja LE!!");
		}
	}

	void OnTriggerExit(Collider collide)
	{
		collision = false;
	}
}
