using UnityEngine;
using System.Collections;

public class LeftHand : MonoBehaviour {

	public static bool collision;

	// Use this for initialization
	void Start () {
		collision =false;

	
	}
	
	// Update is called once per frame
	void Update () {
		//colision = false;
	}


	void OnTriggerEnter(Collider colide)
	{

		if (calibrationTrigger.leftHand.GetComponent<Renderer> ().enabled == true && colide.tag == "Lhand" && calibrationTrigger.all!=true && calibrationTrigger.now) {

			calibrationTrigger.lHand = true;
		}

		if (colide.tag == "Lhand" && gameObject.GetComponent<Renderer> ().enabled == true) {
			collision = true;


		}// else
			//collision = false;

	}

	void OnTriggerStay(Collider colide)
	{
		if (colide.tag == "Lhand" && gameObject.GetComponent<Renderer> ().enabled == true) {
			collision = true;
			//Debug.Log ("Kolizja LE!!");
		}
	}

	void OnTriggerExit(Collider collide)
	{
		collision = false;
	}
}
