﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class calibrationTrigger : MonoBehaviour {
	
	//GameObject point1= shining.point1;
	public  GameObject trigger;
	public  GameObject triggerNext;
	public static bool all;

	public static GameObject leftHand ;
	public static GameObject rightHand;
	public static GameObject leftElbow;
	public static GameObject rightElbow;
	public static GameObject leftKnee;
	public static GameObject rightKnee;
	public static GameObject leftFoot;
	public static GameObject rightFoot;
//	public Collider leftHpoint;
	//public static Collider sender;

	public static bool lHand;
	public static bool rHand;
	public static bool lElbow;
	public static bool rElbow;
	public static bool lKnee;
	public static bool rKnee;
	public static bool lFoot;
	public static bool rFoot;




	public GameObject[] array=new GameObject[8] {leftHand,rightHand,leftElbow,rightElbow,leftKnee,rightKnee, leftFoot, rightFoot};
	
	//bool colExist;
	
	//public static bool ob1;
	//public static bool ob2;




	int frame=0;
	int speedShine=80;
	
	GameObject shiningOb;
	
	void noShine(GameObject sender){
		
		sender.GetComponent<Renderer>().material.SetFloat( "_Shininess", 1);
		
	}
	void Shine(GameObject sender){
		
		sender.GetComponent<Renderer>().material.SetFloat( "_Shininess", 0);
		
		
	}

	
	// Use this for initialization
	void Start () {
		all = false;

		leftHand = GameObject.Find("LeftHandPoint");
		rightHand = GameObject.Find ("RightHandPoint");
		leftElbow = GameObject.Find ("LeftElbowPoint");
		rightElbow = GameObject.Find ("RightElbowPoint");
		leftKnee = GameObject.Find ("LeftKneePoint");
		rightKnee = GameObject.Find ("RightKneePoint");
		leftFoot = GameObject.Find ("LeftFootPoint");
		rightFoot = GameObject.Find ("RightFootPoint");


		leftHand.GetComponent<Renderer> ().enabled=true;
		rightHand.GetComponent<Renderer> ().enabled=false;
		leftElbow.GetComponent<Renderer> ().enabled = false;
		rightElbow.GetComponent<Renderer> ().enabled = false;
		leftKnee.GetComponent<Renderer> ().enabled = false;
		rightKnee.GetComponent<Renderer> ().enabled = false;
		leftFoot.GetComponent<Renderer> ().enabled = false;
		rightFoot.GetComponent<Renderer> ().enabled = false;



		lHand = false;
		rHand = false;
		lElbow = false;
		rElbow = false;
		lKnee = false;
		rKnee = false;
		lFoot = false;
		rFoot = false;

		//Debug.Log (leftHand);

	}


	IEnumerator waitFunction() 
	{

		yield return new WaitForSeconds(3);

	}

	void TriggerOK(int i)
	{
		trigger = array [i];
		if (i < 7) {
			triggerNext = array [i+1];
			trigger.GetComponent<Renderer> ().enabled = false;
			triggerNext.GetComponent<Renderer>().enabled=true;

		} else {
			trigger.GetComponent<Renderer> ().enabled = false;
			all=true;
			for(int k=0; k<=7; k++)
			{
				array[k].GetComponent<Renderer>().enabled=true;
				StartCoroutine (waitFunction ());
			}

		}

	}
	
	// Update is called once per frame
	void Update () {


		frame=Time.frameCount;
		
		if(((frame%speedShine)<=(speedShine/2)) && ((frame%speedShine)>0))
		{
			//position.Add(new Vector3(jeden.transform.position.x,jeden.transform.position.y, jeden.transform.position.z));
			if (leftHand.GetComponent<Renderer> ().enabled==true) 
				Shine (leftHand);
			if(rightHand.GetComponent<Renderer> ().enabled==true)
				Shine (rightHand);
			if(leftElbow.GetComponent<Renderer> ().enabled ==true)
				Shine (leftElbow);
			if(rightElbow.GetComponent<Renderer> ().enabled ==true)
				Shine (rightElbow);
			if (leftKnee.GetComponent<Renderer> ().enabled ==true) {
				Shine (leftKnee);				
			}
			if (rightKnee.GetComponent<Renderer> ().enabled ==true) {
				Shine (rightKnee);				
			}
			if (leftFoot.GetComponent<Renderer> ().enabled ==true) {
				Shine (leftFoot);
			}
			if (rightFoot.GetComponent<Renderer> ().enabled ==true) {
				Shine (rightFoot);
			}
			
			
		}
		if(((frame%speedShine)>(speedShine/2)) && ((frame%speedShine)<=(speedShine-1)))
		{
			if (leftHand.GetComponent<Renderer> ().enabled==true) 
				noShine (leftHand);
			if(rightHand.GetComponent<Renderer> ().enabled==true)
				noShine (rightHand);
			if(leftElbow.GetComponent<Renderer> ().enabled ==true)
				noShine (leftElbow);
			if(rightElbow.GetComponent<Renderer> ().enabled ==true)
				noShine (rightElbow);
			if (leftKnee.GetComponent<Renderer> ().enabled ==true) {
				noShine (leftKnee);				
			}
			if (rightKnee.GetComponent<Renderer> ().enabled ==true) {
				noShine (rightKnee);				
			}
			if (leftFoot.GetComponent<Renderer> ().enabled ==true) {
				noShine (leftFoot);
			}
			if (rightFoot.GetComponent<Renderer> ().enabled ==true) {
				noShine (rightFoot);
			}
		}

		if (lHand) {
			TriggerOK(0);
			lHand=false;
		}
		if (rHand) {
			TriggerOK(1);
			rHand=false;
		}
		if (lElbow) {
			TriggerOK(2);
			lElbow=false;
		}
		if (rElbow) {
			TriggerOK(3);
			rElbow=false;
		}
		if (lKnee) {
			TriggerOK(4);
			lKnee=false;
		}
		if (rKnee) {
			TriggerOK(5);
			rKnee=false;
		}
		if (lFoot) {
			TriggerOK(6);
			lFoot=false;
		}
		if (rFoot) {
			TriggerOK(7);
			rFoot=false;
		}



		
	}
	

		
		

}