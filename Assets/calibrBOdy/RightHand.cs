using UnityEngine;
using System.Collections;

public class RightHand : MonoBehaviour {
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
		if(calibrationTrigger.rightHand.GetComponent<Renderer> ().enabled==true && colide.tag == "Rhand" && calibrationTrigger.all!=true)
			calibrationTrigger.rHand = true;

		
		if (colide.tag == "Rhand" && gameObject.GetComponent<Renderer> ().enabled == true) {
			collision = true;
			
			
		} //else
			//collision = false;
		
	}


	void OnTriggerStay(Collider colide)
	{
		if (colide.tag == "Rhand" && gameObject.GetComponent<Renderer> ().enabled == true) {
			collision = true;
			//Debug.Log ("Kolizja LE!!");
		}
	}
	void OnTriggerExit(Collider collide)
	{
		collision = false;
	}
		

}
