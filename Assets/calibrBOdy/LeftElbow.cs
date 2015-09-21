using UnityEngine;
using System.Collections;

public class LeftElbow : MonoBehaviour {

	public static bool collision;
	public static bool lHand;
	// Use this for initialization
	void Start () {
		collision = false;
		lHand = true;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("LeftElbow" + collision);
		//Debug.Log ("LeftHand" + LeftHand.collision);

	}

	void OnTriggerEnter(Collider colide)
	{
		if(calibrationTrigger.leftElbow.GetComponent<Renderer> ().enabled==true && colide.tag == "LElbow" && calibrationTrigger.all!=true && calibrationTrigger.now)
			calibrationTrigger.lElbow = true;
		if (colide.tag == "LElbow" && gameObject.GetComponent<Renderer> ().enabled == true) {
			collision = true;
			//Debug.Log ("Kolizja LE!!");
		} //else 
			//collision = false;
		/*if (collision && LeftHand.collision) {
			lHand=!lHand;
		}*/

	}

	void OnTriggerStay(Collider colide)
	{
		if (colide.tag == "LElbow" && gameObject.GetComponent<Renderer> ().enabled == true) {
			collision = true;
			//Debug.Log ("Kolizja LE!!");
		}
	}

	void OnTriggerExit(Collider collide)
	{
		collision = false;
	}

}
