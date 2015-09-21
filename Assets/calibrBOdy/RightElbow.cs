using UnityEngine;
using System.Collections;

public class RightElbow : MonoBehaviour {
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
		if(calibrationTrigger.rightElbow.GetComponent<Renderer> ().enabled==true && colide.tag == "RElbow" && calibrationTrigger.all!=true)
			calibrationTrigger.rElbow = true;

		if (colide.tag == "RElbow" && gameObject.GetComponent<Renderer> ().enabled == true) {
			collision = true;
			
		} //else 
			//collision = false;
		/*if (collision && LeftHand.collision) {
			lHand=!lHand;
		}*/
		
	}

	void OnTriggerStay(Collider colide)
	{
		if (colide.tag == "RElbow" && gameObject.GetComponent<Renderer> ().enabled == true) {
			collision = true;
			//Debug.Log ("Kolizja LE!!");
		}
	}
	
	void OnTriggerExit(Collider collide)
	{
		collision = false;
	}
		

}
