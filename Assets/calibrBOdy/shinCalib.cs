using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class shinCalib : MonoBehaviour {
	
	public GameObject leftHand ;
	public GameObject rightHand;
	public GameObject leftElbow;
	public GameObject rightElbow;
	public GameObject leftKnee;
	public GameObject rightKnee;
	public GameObject leftFoot;
	public GameObject rightFoot;


	
	
	
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

	}
	
	// Update is called once per frame
	void Update () {
		
		frame=Time.frameCount;
		
		if(((frame%speedShine)<=(speedShine/2)) && ((frame%speedShine)>0))
		{
			//position.Add(new Vector3(jeden.transform.position.x,jeden.transform.position.y, jeden.transform.position.z));
			if (calibrationTrigger.lHand) 
				Shine (leftHand);
			if(calibrationTrigger.rHand)
				Shine (rightHand);
			if(calibrationTrigger.lElbow)
				Shine (leftElbow);
			if(calibrationTrigger.rElbow)
				Shine (rightElbow);
			if (calibrationTrigger.lKnee) {
				Shine (leftKnee);				
			}
			if (calibrationTrigger.rKnee) {
				Shine (rightKnee);				
			}
			if (calibrationTrigger.lFoot) {
				Shine (leftFoot);
			}
			if (calibrationTrigger.rFoot) {
				Shine (rightFoot);
			}
			

		}
		if(((frame%speedShine)>(speedShine/2)) && ((frame%speedShine)<=(speedShine-1)))
		{
			if (calibrationTrigger.lHand) 
				noShine (leftHand);
			if(calibrationTrigger.rHand)
				noShine (rightHand);
			if(calibrationTrigger.lElbow)
				noShine (leftElbow);
			if(calibrationTrigger.rElbow)
				noShine (rightElbow);
			if (calibrationTrigger.lKnee) {
				noShine (leftKnee);				
			}
			if (calibrationTrigger.rKnee) {
				noShine (rightKnee);				
			}
			if (calibrationTrigger.lFoot) {
				noShine (leftFoot);
			}
			if (calibrationTrigger.rFoot) {
				noShine (rightFoot);
			}
		}
		
		/*Transform parent = jeden.transform;
		foreach(Transform child in parent){ child.gameObject.layer = LayerMask.NameToLayer("Box"); }*/
		/*if (Cart.points == 0) {
			startPosition = new Vector3 (jeden.transform.position.x,jeden.transform.position.y, jeden.transform.position.z);
		}
*/

		//Debug.Log (frame);
		
	}
}