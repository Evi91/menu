using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class exer1 : MonoBehaviour {


	public static int points;
	bool punkty;
	public static int exerNum;
	public static bool isready;
	public static bool wait;
	//GameObject point1= shining.point1;
	//public  GameObject trigger;
	//public  GameObject triggerNext;
	//public static bool all;

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


	//if true - forward, false = back;
	public static bool lHand;
	public static bool rHand;
	public static bool lElbow;
	public static bool rElbow;
	public static bool lKnee;
	public static bool rKnee;
	public static bool lFoot;
	public static bool rFoot;
	float pozitionzLeg;



	//const float handPositionZ=6.629f;
	const float backHand=0.112f;
	const float frontHand=-0.09f;
	const float backLeg = 0.192f;
	float lHzPoz;
	float lEzPoz;

	private int coolDown = 0;


	
	public static List<Vector3> position = new List<Vector3>();


	public Vector3[] startPos = new Vector3[8];



	public GameObject[] allObj=new GameObject[8] {leftHand,rightHand,leftElbow,rightElbow,leftKnee,rightKnee, leftFoot, rightFoot};
	//public GameObject[] second=new GameObject[4]{rightHand,rightElbow,leftKnee, leftFoot};

	public static float[] positionz= new float[4]{0f,0f,0f,0f};


	
	float x=0;
	int timeLeft=0;
	
	int frame=0;
	int speedShine=80;
	
	GameObject shiningOb;
	
	void noShine(GameObject sender){
		
		sender.GetComponent<Renderer>().material.SetFloat( "_Shininess", 1);
		
	}
	void Shine(GameObject sender){
		
		sender.GetComponent<Renderer>().material.SetFloat( "_Shininess", 0);
		
		
	}

	void changePos(int i)
	{
		if (i == 1) {
			leftHand.GetComponent<Renderer> ().enabled=true;
			rightHand.GetComponent<Renderer> ().enabled=false;
			leftElbow.GetComponent<Renderer> ().enabled = false;
			rightElbow.GetComponent<Renderer> ().enabled = true;
			leftKnee.GetComponent<Renderer> ().enabled = true;
			rightKnee.GetComponent<Renderer> ().enabled = true;
			leftFoot.GetComponent<Renderer> ().enabled = false;
			rightFoot.GetComponent<Renderer> ().enabled = false;
			for(int k=0; k<8; k++)
			{
				allObj[k].transform.position=startPos[k];
			}


		}
		if (i == 2) {
			leftHand.GetComponent<Renderer> ().enabled=true;
			rightHand.GetComponent<Renderer> ().enabled=true;
			leftElbow.GetComponent<Renderer> ().enabled = false;
			rightElbow.GetComponent<Renderer> ().enabled = false;
			leftKnee.GetComponent<Renderer> ().enabled = true;
			rightKnee.GetComponent<Renderer> ().enabled = true;
			leftFoot.GetComponent<Renderer> ().enabled = false;
			rightFoot.GetComponent<Renderer> ().enabled = false;

			leftHand.transform.position=new Vector3(leftHand.transform.position.x+0.187f,leftHand.transform.position.y -0.414f ,leftHand.transform.position.z+0.512f);
			rightHand.transform.position=new Vector3(rightHand.transform.position.x-0.187f,rightHand.transform.position.y-0.414f,rightHand.transform.position.z+0.512f);

			
		}

		if (i == 3) {
			for(int k=0; k<2; k++)
			{
				allObj[k].transform.position=startPos[k];
			}
		}

		isready = true;
	}

	
	// Use this for initialization
	void Start () {
		//all = false;
		for(int i=0; i<8; i++)
		{
			startPos[i]=new Vector3 (allObj[i].transform.position.x,allObj[i].transform.position.y,allObj[i].transform.position.z);
		}
		points = 0;
		exerNum = 1;

		isready = true;


		leftHand = GameObject.Find ("LeftHandPoint");
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
		rightElbow.GetComponent<Renderer> ().enabled = true;
		leftKnee.GetComponent<Renderer> ().enabled = true;
		rightKnee.GetComponent<Renderer> ().enabled = true;
		leftFoot.GetComponent<Renderer> ().enabled = false;
		rightFoot.GetComponent<Renderer> ().enabled = false;

	

		pozitionzLeg=rightKnee.transform.position.z;
		/*lHand = true;
		rHand = false;
		lElbow = true;
		rElbow = false;
		lKnee = false;
		rKnee = true;
		lFoot = false;
		rFoot = true;*/

	}

	
	
	IEnumerator waitFunction() 
	{
		
		yield return new WaitForSeconds(3);
		
	}
	
	void TriggerOK(int i)
	{

		
	}
	
	// Update is called once per frame
	void Update () {

	//	x += Time.deltaTime;
	//	timeLeft = (int)x;
		//Debug.Log ("Kolizja "+ timeLeft + LeftHand.collision + RightKnee.collision + RightElbow.collision + LeftKnee.collision);

		if (exerNum == 1) {
			if(!isready)
			{
				changePos(exerNum);
			}
			if (LeftHand.collision && RightKnee.collision && RightElbow.collision && LeftKnee.collision) {
				if (!punkty) {
					points++;
					punkty = !punkty;
				}
				//lewa reka, prawa noga
				leftHand.GetComponent<Renderer> ().enabled = false;
				leftElbow.GetComponent<Renderer> ().enabled = true;
				rightKnee.transform.position = new Vector3 (rightKnee.transform.position.x, rightKnee.transform.position.y, pozitionzLeg + 0.179f);
				//Debug.Log ("Najpierw:" + rightKnee.transform.position.z);
				//prawa reka, lewa noga
				rightHand.GetComponent<Renderer> ().enabled = true;
				rightElbow.GetComponent<Renderer> ().enabled = false;
				leftKnee.transform.position = new Vector3 (leftKnee.transform.position.x, leftKnee.transform.position.y, pozitionzLeg);
				//Debug.Log ("Kolizja!! ");
			} else if (LeftElbow.collision && RightKnee.collision && RightHand.collision && LeftKnee.collision) {
				if (punkty) {
					points++;
					punkty = !punkty;
				}
				leftHand.GetComponent<Renderer> ().enabled = true;
				leftElbow.GetComponent<Renderer> ().enabled = false;
				rightKnee.transform.position = new Vector3 (rightKnee.transform.position.x, rightKnee.transform.position.y, pozitionzLeg);
				//Debug.Log ("Potem:" + rightKnee.transform.position.z);

				//prawa reka, lewa noga

				rightElbow.GetComponent<Renderer> ().enabled = true;
				rightHand.GetComponent<Renderer> ().enabled = false;
				leftKnee.transform.position = new Vector3 (leftKnee.transform.position.x, rightKnee.transform.position.y, pozitionzLeg + 0.179f);
				//Debug.Log ("Kolizja!! ");
			
			}
		}


		if (exerNum == 2) {
			if(!isready)
			{
				changePos(exerNum);
			}

			if(coolDown > 0 )
			{
				coolDown--;
			}
			else
			{

				if(LeftHand.collision && RightHand.collision && RightKnee.collision && LeftKnee.collision && !wait)
				{
					Debug.Log ("pierwszaPetlaWeszla" + rightKnee.transform.position.z);
					if (!punkty) {
						points++;
						punkty = !punkty;
					}
					rightKnee.transform.position = new Vector3 (rightKnee.transform.position.x, rightKnee.transform.position.y, pozitionzLeg + 0.179f);
					leftKnee.transform.position = new Vector3 (leftKnee.transform.position.x, leftKnee.transform.position.y, pozitionzLeg);

					Debug.Log ("pierwszaPo" + rightKnee.transform.position.z);

					coolDown = 50;
				}

				 if(LeftHand.collision && RightHand.collision && RightKnee.collision && LeftKnee.collision  && wait)
				{
					Debug.Log ("DrugaaPetlaWeszla" + rightKnee.transform.position.z);
					if (punkty) {
						points++;
						punkty = !punkty;
					}
					rightKnee.transform.position = new Vector3 (rightKnee.transform.position.x, rightKnee.transform.position.y, pozitionzLeg);
					leftKnee.transform.position = new Vector3 (leftKnee.transform.position.x, leftKnee.transform.position.y, pozitionzLeg+ 0.179f);
					Debug.Log ("drugaPo" + rightKnee.transform.position.z);

					coolDown = 50;

				}
				wait=!wait;
			}

		}

		if (exerNum == 3) {
			if (!isready) {
				changePos (exerNum);
			}
			if (coolDown > 0) {
				coolDown--;
			} else {

				if (LeftHand.collision && RightHand.collision && RightKnee.collision && LeftKnee.collision && rightKnee.transform.position.z == pozitionzLeg) {
					Debug.Log ("pierwszaPetlaWeszla" + rightKnee.transform.position.z);
					if (!punkty) {
						points++;
						punkty = !punkty;
					}
					rightKnee.transform.position = new Vector3 (rightKnee.transform.position.x, rightKnee.transform.position.y, pozitionzLeg + 0.179f);
					leftKnee.transform.position = new Vector3 (leftKnee.transform.position.x, leftKnee.transform.position.y, pozitionzLeg);
					Debug.Log ("pierwszaPo" + rightKnee.transform.position.z);
					coolDown = 50;
				} else if (LeftHand.collision && RightHand.collision && RightKnee.collision && LeftKnee.collision && leftKnee.transform.position.z == pozitionzLeg) {
					Debug.Log ("DrugaaPetlaWeszla" + rightKnee.transform.position.z);
					if (punkty) {
						points++;
						punkty = !punkty;
					}
					rightKnee.transform.position = new Vector3 (rightKnee.transform.position.x, rightKnee.transform.position.y, pozitionzLeg);
					leftKnee.transform.position = new Vector3 (leftKnee.transform.position.x, leftKnee.transform.position.y, pozitionzLeg + 0.179f);
					Debug.Log ("drugaPo" + rightKnee.transform.position.z);
					coolDown = 50;
				}

			}
		}
















	//first exe!!!!
		/*if (LeftElbow.collision) {
			if(LeftElbow.lHand)*/
		/*if(colisionWalk.first )
			{

				for(int i=0; i<4; i++)
				{
					if(i<2)
						first[i].transform.position=new Vector3(first[i].transform.position.x,first[i].transform.position.y,positionz[i]+backHand);
					if(i>=2)
						first[i].transform.position=new Vector3(first[i].transform.position.x,first[i].transform.position.y,positionz[i]);
				}
			}
		else
			{
				for(int i=0; i<4; i++)
				{
					if(i<2)
						first[i].transform.position=new Vector3(first[i].transform.position.x,first[i].transform.position.y,positionz[i]+frontHand);
					if(i>=2);
						first[i].transform.position=new Vector3(first[i].transform.position.x,first[i].transform.position.y,positionz[i]+backLeg);
					
				}
			}

*/




		






		
		frame=Time.frameCount;
		
	/*	if(((frame%speedShine)<=(speedShine/2)) && ((frame%speedShine)>0))
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

*/
		
		
		
	}

	void OnGUI()
	{
		GUIStyle literki = new GUIStyle ("Label");
		literki.fontSize = ((Screen.width / 20));
		literki.fontStyle = FontStyle.Bold;
		
		GUI.Label (new Rect (0, 0, 300, 300), "Pkt: " + points, literki);
	}

}
