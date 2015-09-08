using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class shining : MonoBehaviour {

	public GameObject jeden;
	public GameObject dwa;
	public GameObject trzy;
	public GameObject cztery;
	public GameObject point1;
	public GameObject point2;
	public GameObject point3;
	public GameObject point4;
	public GameObject powderL;
	public GameObject powderR;
	public static List<Vector3> position = new List<Vector3>();



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
		position.Add(new Vector3(jeden.transform.position.x,jeden.transform.position.y, jeden.transform.position.z));
		position.Add(new Vector3(dwa.transform.position.x,dwa.transform.position.y, dwa.transform.position.z));
		position.Add(new Vector3(trzy.transform.position.x,trzy.transform.position.y, trzy.transform.position.z));
		position.Add(new Vector3(cztery.transform.position.x,cztery.transform.position.y, cztery.transform.position.z));
	}
	
	// Update is called once per frame
	void Update () {

		frame=Time.frameCount;

		if(((frame%speedShine)<=(speedShine/2)) && ((frame%speedShine)>0))
		{
			//position.Add(new Vector3(jeden.transform.position.x,jeden.transform.position.y, jeden.transform.position.z));
			if (Cart.points == 0) 
				Shine (jeden);
			else if(Cart.points == 1)
				Shine (dwa);
			else if(Cart.points == 2)
				Shine (trzy);
			else if(Cart.points == 3)
				Shine (cztery);
			if (SphereTriggerPoint1.rend1.enabled==true) {
				Shine (point1);				
			}
			else if (SphereTriggerPoint2.rend2.enabled==true) {
				Shine (point2);				
			}
			if (SphereTriggerPoint3.rend3.enabled==true) {
				Shine (point3);
			}
			else if (SphereTriggerPoint4.rend4.enabled==true) {
				Shine (point4);
			}

			if(Cart.points==6)
			{
				Shine(powderL);
				Shine(powderR);
			}
		}
		if(((frame%speedShine)>(speedShine/2)) && ((frame%speedShine)<=(speedShine-1)))
		{
			if (Cart.points == 0) 
				noShine (jeden);
			else if(Cart.points == 1)
				noShine (dwa);
			else if(Cart.points == 2)
				noShine (trzy);
			else if(Cart.points == 3)
				noShine (cztery);
			if (SphereTriggerPoint1.rend1.enabled==true) {
				noShine (point1);
			}
			else if (SphereTriggerPoint2.rend2.enabled==true) {
				noShine (point2);
			}
			if (SphereTriggerPoint3.rend3.enabled==true) {
				noShine (point3);
			}
			else if (SphereTriggerPoint4.rend4.enabled==true) {
				noShine (point4);
			}
			if(Cart.points==6)
			{
				noShine(powderL);
				noShine(powderR);
			}
		}

		/*Transform parent = jeden.transform;
		foreach(Transform child in parent){ child.gameObject.layer = LayerMask.NameToLayer("Box"); }*/
		/*if (Cart.points == 0) {
			startPosition = new Vector3 (jeden.transform.position.x,jeden.transform.position.y, jeden.transform.position.z);
		}
*/
		if (Cart.points == 1) {
			//startPosition = new Vector3 (dwa.transform.position.x,dwa.transform.position.y, dwa.transform.position.z);
			Transform parent = dwa.transform.parent;
			parent.gameObject.layer = LayerMask.NameToLayer ("Box");
			Transform parent2 = jeden.transform.parent;
			parent2.gameObject.layer = LayerMask.NameToLayer ("inCart");
		} else if (Cart.points == 2) {
			//startPosition = new Vector3 (trzy.transform.position.x,trzy.transform.position.y, trzy.transform.position.z);
			trzy.layer = LayerMask.NameToLayer ("Box");
			Transform parent2 = dwa.transform.parent;
			parent2.gameObject.layer = LayerMask.NameToLayer ("inCart");
		} else if (Cart.points == 3) {
			//startPosition = new Vector3 (cztery.transform.position.x,cztery.transform.position.y, cztery.transform.position.z);
			cztery.layer = LayerMask.NameToLayer ("Box");
			trzy.layer = LayerMask.NameToLayer ("inCart");
			trzy.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		} else if (Cart.points == 4) {
			
			cztery.layer = LayerMask.NameToLayer ("inCart");
			cztery.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);


		} 
		//Debug.Log (frame);

	}
}