using UnityEngine;
using System.Collections;

public class colisionWalk : MonoBehaviour {


	public static bool first;// left Hand, right Leg
	public static bool second;// right Hand, left Leg
	public static bool lLeg;
	public static bool rLeg;
	int col;
	// Use this for initialization
	void Start () {
		first = true;
		rLeg = false;
		second = false;
		lLeg = true;
		col = 0;

	
	}

/*	public void change()
	{
		first=!first;
		Debug.Log ("Kolizja!!!");
		RightKnee.collision = false;

	}*/
	// Update is called once per frame
	void Update () {

		if (LeftHand.collision && RightKnee.collision /* &&  RightFoot.collision*/) {

			

		}
	
	}
}
