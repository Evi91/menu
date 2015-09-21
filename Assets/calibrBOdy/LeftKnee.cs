using UnityEngine;
using System.Collections;

public class LeftKnee : MonoBehaviour {
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
		if(calibrationTrigger.leftKnee.GetComponent<Renderer> ().enabled==true && colide.tag == "LKnee" && calibrationTrigger.all!=true)
			calibrationTrigger.lKnee = true;
		
	

		if (colide.tag == "LKnee") {
			collision = true;
		
		
		}
		//else 
			//collision = false;
	
	
	
	}

	void OnTriggerStay(Collider colide)
	{
		if (colide.tag == "LKnee" && gameObject.GetComponent<Renderer> ().enabled == true) {
			collision = true;
			//Debug.Log ("Kolizja LE!!");
		}
	}


	void OnTriggerExit(Collider collide)
	{
		collision = false;
	}

}
