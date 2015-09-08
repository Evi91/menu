using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Camera camera1;
	bool busy;
	int frame=0;
	//public Camera camera2;
	// Use this for initialization
	void Start () {
		//camera1.enabled = true;
		//camera2.enabled = false;
		//camera1.GetComponent<AudioListener>().enabled = true;
		//camera2.GetComponent<AudioListener>().enabled = false;
		//camera2.GetComponent<KinectManager>().enabled = false;
		//camera2.GetComponent<shining>().enabled = false;
		busy = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (!busy) {
			if (SphereTriggerPoint1.startCam2 ) {
				camera1.transform.position = new Vector3 (1.4f, -3.3f, 8.67f);
				camera1.transform.rotation = new Quaternion (4f, 180f, 0f, 0f);
				SphereTriggerPoint1.startCam2 = false;
				Debug.Log ("Druga Kamera");
			}
			if (powderPoints.startCam3) {

				camera1.transform.position = new Vector3 (-78.4f, -3.3f, 8.67f);
				//camera1.transform.rotation= new Quaternion(0f,0f,0f,0f);
				changeCamera();
				//StartCoroutine (waitFunction ());
				Debug.Log ("Trzecia Kamera");
				//powderPoints.startCam3 = false;
				//SphereTriggerPoint1.startCam2 = true;

			}
		}
}


	public void changeCamera()
	{

		StartCoroutine (waitFunction ());

	}

	IEnumerator waitFunction() 
	{
		busy = true;
		//Debug.Log ("Jestem w petli!!!!!!!!!!!!");
		yield return new WaitForSeconds(10);
		powderPoints.startCam3=false;
		SphereTriggerPoint1.startCam2 = true;
		busy = false;
		Cart.points++;
		powderPoints.howManyRound++;
		Debug.Log ("Ilosc rund:"+powderPoints.howManyRound);
	}
}