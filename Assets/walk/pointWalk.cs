using UnityEngine;
using System.Collections;

public class pointWalk : MonoBehaviour {
	public Camera camera1;
	public static bool startCam2;
	public static bool startCam1;

	// Use this for initialization
	void Start () {
		startCam1 = true;
		startCam2 = false;

	
	}
	
	// Update is called once per frame
	void Update () {
		if(exer1.points==4)
		{
			exer1.exerNum=2;
			exer1.isready=false;
			exer1.points=5;
			/*startCam1=false;
			startCam2=true;
			exer1.points=5;*/
		}
		else if(exer1.points==9)
		{
			exer1.exerNum=3;
			exer1.isready=false;
			exer1.points=10;
			/*startCam1=false;
			startCam2=true;
			exer1.points=5;*/
		}
		else if(exer1.points==14)
		{
			exer1.exerNum=1;
			startCam1=false;
			startCam2=true;
			exer1.points=5;
			exer1.points=15;
			exer1.isready=false;
		}
	
	}

}
