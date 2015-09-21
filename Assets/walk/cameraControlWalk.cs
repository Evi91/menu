using UnityEngine;
using System.Collections;

public class cameraControlWalk : MonoBehaviour {
	
	public Camera camera1;
	public static bool busy;
	public static bool startTimer;
	int frame=0;
	//public Vector3 cam1Pos= new Vector3(2.6f,-2.569f,7.715f);

	void Start () {

		busy = false;
		startTimer = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!busy) {
			if(pointWalk.startCam1)
			{
				camera1.transform.position= new Vector3(2.6f,-2.569f,7.715f);
			}
			if (pointWalk.startCam2 && startTimer==false) {
				startTimer=true;
				camera1.transform.position = new Vector3 (-78.4f, -3.3f, 8.67f);

				
			}
		}
	}
	
	
	public void changeCamera()
	{
		
		//StartCoroutine (waitFunction ());
		
	}
	
	/*	IEnumerator waitFunction() 
	{
		busy = true;
		//Debug.Log ("Jestem w petli!!!!!!!!!!!!");
		yield return new WaitForSeconds(2);
		powderPoints.startCam3=false;
		SphereTriggerPoint1.startCam2 = true;
		busy = false;
		Cart.points++;
		powderPoints.howManyRound++;
		Debug.Log ("Ilosc rund:"+powderPoints.howManyRound);
	}*/
}