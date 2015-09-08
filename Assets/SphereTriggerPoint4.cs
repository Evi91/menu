using UnityEngine;
using System.Collections;

public class SphereTriggerPoint4 : MonoBehaviour {
	
	//GameObject point1= shining.point1;
	public static Renderer rend3;
	public static Renderer rend4;
	public GameObject point3;
	public GameObject point4;
	//public static bool ob1;
	//public static bool ob2;
	public static bool colid4;
	
	
	// Use this for initialization
	void Start () {
		rend3 = point3.GetComponent<Renderer> ();
		rend4 = point4.GetComponent<Renderer> ();
		rend3.enabled = false;
		rend4.enabled = false;
		colid4 = false;
	}
	
	// Update is called once per frame
	void Update () {		
	}
	
	
	
	void OnTriggerEnter(Collider colide)
	{
		if (colide.tag == "Rhand" && powderPoints.startRound==true) {
			colid4=true;
			}
		}

}
