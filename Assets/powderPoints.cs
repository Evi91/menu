﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class powderPoints : MonoBehaviour{

	public GameObject powderL;
	public static bool startRound; 
	public static bool stopRound;
	public static int howManyRound;
	public static bool startCam3;
	// Use this for initialization
	void Start () {
		startRound = false;
		stopRound = false;
		startCam3 = false;
		howManyRound = 0;
		//endRound = false;
	}



	void startR()
	{
		SphereTriggerPoint1.rend1.enabled = true;
		SphereTriggerPoint3.rend3.enabled = true;
		//howManyRound++;
		stopRound = true;
	}


	void stopR()
	{
		SphereTriggerPoint1.rend1.enabled = false;
		SphereTriggerPoint3.rend3.enabled = false;
		stopRound = false;
	}


	// Update is called once per frame
	void Update () {
		if (Cart.points == 7 || Cart.points == 16 || Cart.points == 25 || Cart.points == 34) {

			startRound = true;
			startR ();
		} 

		if (Cart.points == 15 || Cart.points == 24 || Cart.points == 33 || Cart.points == 42) {
			//Debug.Log (howManyRound);
		/*	if(howManyRound==4)
			{
				Destroy(powderL);
			}*/
			if(stopRound==true){
					stopR();
					startCam3=true;

			}

		}
		
	
	}



	void OnTriggerExit(Collider other) {
		if(Cart.points==6 || Cart.points == 15 || Cart.points == 24 || Cart.points == 33){
			Cart.points++;
		}

	}



}