﻿using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {


	float x;
	int timeLeft;
	string time;
	bool showText;


	// Use this for initialization
	void Start () {
		x = 5f; 
		timeLeft= (int) x;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (CameraControl.startTimer == true) {
			showText=true;
			CameraControl.busy=true;
			timeLeft=(int)x;
			time=timeLeft.ToString();

			Debug.Log ("TimeLeft:" + timeLeft +"showText:" + showText);
			if (powderPoints.startCam3 == true && CameraControl.startTimer == true && timeLeft > 0) {
				x -= Time.deltaTime;
				timeLeft = (int)x;
			} else if (timeLeft == 0) {
				powderPoints.startCam3 = false;
				Cart.points++;
				SphereTriggerPoint1.startCam2 = true;
				CameraControl.startTimer = false;
				x = 5;
				CameraControl.busy=false;
				showText=false;
			}
		}
		if (powderPoints.end) {
			foreach(GameObject point in GameObject.FindGameObjectsWithTag("point")) {
				point.GetComponent<SphereCollider>().enabled = false;    
			}
			foreach(GameObject powder in GameObject.FindGameObjectsWithTag("proszek")) {
				Destroy(powder);   
			}
		}
	}

void OnGUI(){

		GUIStyle literki = new GUIStyle ("button");
		GUI.backgroundColor = Color.clear;
		literki.fontSize = ((Screen.width / 4) / 5);
		literki.fontStyle = FontStyle.Bold;
		literki.alignment = TextAnchor.MiddleCenter;
	
		if (showText) {
			//Debug.Log ("Show Text jest!");
			time=timeLeft.ToString();
		
			//GUI.Label (new Rect (Screen.width / 3, Screen.width / 30, Screen.width, Screen.height), "Przerwa potrwa jeszcze:"+time, literki);
			GUI.Label (new Rect (0, 0, Screen.width, Screen.height), "Przerwa potrwa jeszcze \n"+time, literki);
		
		}
	}

	IEnumerator waitFunction() 
	{
		KinectManager.instance.KinectInitialized= false;
		yield return new WaitForSeconds(5);


	}

}
