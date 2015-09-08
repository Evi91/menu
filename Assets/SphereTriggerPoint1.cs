using UnityEngine;
using System.Collections;

public class SphereTriggerPoint1 : MonoBehaviour {

	//GameObject point1= shining.point1;
	public static Renderer rend1;
	public static Renderer rend2;
	public GameObject point1;
	public GameObject point2;
	public static bool startCam2;
	GameObject helper;
	public static bool colid1;

	//bool colExist;

	//public static bool ob1;
	//public static bool ob2;


	// Use this for initialization
	void Start () {
		rend1 = point1.GetComponent<Renderer> ();
		rend2 = point2.GetComponent<Renderer> ();
		rend1.enabled = false;
		rend2.enabled = false;
		startCam2 = false;
		colid1=false;
	}
	
	// Update is called once per frame
	void Update () {

		if (washPowder.isPowderIn) {
			//rend1.enabled=true;
			startCam2 = true;

		}

	}

	void OnColision(){
		rend1.enabled = false;
		rend2.enabled = true;
		SphereTriggerPoint3.rend3.enabled = false;
		SphereTriggerPoint4.rend4.enabled = true;
		Cart.points++;

	}

	void OnTriggerEnter(Collider colide)
	{

		washPowder.isPowderIn=false;
		//GameObject now = colide.gameObject;
		if (colide.tag == "Lhand" && powderPoints.startRound==true) {
			colid1=true;
			//Debug.Log ("Kolizja punkt 1" + colid1);
			//colExist = true;
			if (rend1.enabled == true  && SphereTriggerPoint3.rend3.enabled==true && SphereTriggerPoint3.colid3==true) {
				OnColision();
			} 

		}

	}
}
