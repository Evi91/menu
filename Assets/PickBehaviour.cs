using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AvatarController))]
public class PickBehaviour : MonoBehaviour {

	public Hand LeftHand;
	public Hand RightHand;

	public float Threshold = 10f;

	bool isHolding = false;
	public static bool isHoldingPowderRight = false;
	public static bool isHoldingPowderLeft = false;

	public GameObject holdedObject;
	public GameObject holdedObjectL;
	public GameObject holdedObjectR;


	public GameObject proszekL;
	public GameObject proszekR;


	void Awake()
	{
	}



	// Use this for initialization
	void Start () {



		LeftHand.onCollision += onLeftHandTrigger;
		RightHand.onCollision += onRightHandTrigger;
	}



	void onLeftHandTrigger (GameObject sender)
	{
		if (!(sender.tag == "proszek")) {
			isHolding = true;
			holdedObject = sender;

		} else {
			isHoldingPowderLeft = true;
			holdedObjectL = sender;
		}



	}

	void onRightHandTrigger (GameObject sender)
	{
		//Debug.Log ("Right Hand Collided");
		if (!(sender.tag == "proszek")) {
			isHolding = true;
			holdedObject = sender;
			
		} else {
			isHoldingPowderRight = true;
			holdedObjectR = sender;
		}

	}
	
	// Update is called once per frame
	void Update () 
	{



		if (isHolding) 
		{
			Vector3 center = (LeftHand.transform.position + RightHand.transform.position) / 2f;
			holdedObject.GetComponent<Rigidbody>().isKinematic = true;
			holdedObject.GetComponent<Rigidbody>().MovePosition(center);

			float distance = (LeftHand.transform.position - RightHand.transform.position).magnitude;
			if (distance > Threshold)
			{
				isHolding = false;
				holdedObject.transform.SetParent(null);
				holdedObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
				holdedObject.GetComponent<Rigidbody>().isKinematic = false;
			}
		}

		if (isHoldingPowderRight && holdedObjectR) {

			holdedObjectR.GetComponent<Rigidbody>().isKinematic = true;
			holdedObjectR.GetComponent<Rigidbody>().MovePosition(RightHand.transform.position);

			}

		if (isHoldingPowderLeft && holdedObjectL) {
			
			holdedObjectL.GetComponent<Rigidbody>().isKinematic = true;
			holdedObjectL.GetComponent<Rigidbody>().MovePosition(LeftHand.transform.position);

			
		}
	}

	void OnDrawGizmos()
	{
		if (LeftHand == null)
			return;
		if (RightHand == null)
			return;

		Gizmos.color = Color.red;
		Gizmos.DrawLine(LeftHand.transform.position, RightHand.transform.position);
	}
}
