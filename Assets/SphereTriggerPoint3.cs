using UnityEngine;
using System.Collections;

public class SphereTriggerPoint3 : MonoBehaviour {
	
	//GameObject point1= shining.point1;
	public static Renderer rend3;
	public static Renderer rend4;
	public GameObject point3;
	public GameObject point4;
	//public static bool ob1;
	//public static bool ob2;
	public static bool colid3;
	
	// Use this for initialization
	void Start () {
		rend3 = point3.GetComponent<Renderer> ();
		rend4 = point4.GetComponent<Renderer> ();
		rend3.enabled = false;
		rend4.enabled = false;
		colid3 = false;

	}
	
	// Update is called once per frame
	void Update () {
		
		/*if (washPowder.isPowderIn) {
			rend3.enabled=true;
			
		}*/
		
	}
	
	
	
	void OnTriggerEnter(Collider colide)
	{
		washPowder.isPowderIn=false;
		//GameObject now = colide.gameObject;
		if (colide.tag == "Rhand" && powderPoints.startRound==true) {
			colid3=true;
				}

	}
}
