using UnityEngine;
using System.Collections;

public class SphereTriggerPoint2 : MonoBehaviour {
	
	//GameObject point1= shining.point1;
	public static Renderer rend1;
	public static Renderer rend2;
	public GameObject point1;
	public GameObject point2;
	public static bool startCam2;
	GameObject helper;
	public static bool colid2;
	
	//public static bool ob1;
	//public static bool ob2;
	
	
	// Use this for initialization
	void Start () {
		rend1 = point1.GetComponent<Renderer> ();
		rend2 = point2.GetComponent<Renderer> ();
		rend1.enabled = false;
		rend2.enabled = false;
		startCam2 = false;
		colid2 = false;
	}
	
	// Update is called once per frame
	void Update () {

	
	}


	void OnColision(){
		rend1.enabled = true;
		rend2.enabled = false;
		SphereTriggerPoint3.rend3.enabled = true;
		SphereTriggerPoint4.rend4.enabled = false;
		Cart.points++;
	}
	
	
	void OnTriggerEnter(Collider colide)
	{
		//GameObject now = colide.gameObject;
		if (colide.tag == "Lhand" && powderPoints.startRound==true) {
			colid2=true;
			if (rend2.enabled == true && SphereTriggerPoint4.colid4==true) {
				OnColision();
			} 
		}
	}
}
