using UnityEngine;
using System.Collections;

public class Hand : MonoBehaviour 
{
	public delegate void Handler(GameObject sender);

	public event Handler onTrigger;
	public event Handler onCollision;

	// Use this for initialization
	void Start () 
	{
	}

	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider collider)
	{
		if (onTrigger != null)
		{
			onTrigger (collider.gameObject);
		}

	}

	void OnCollisionEnter(Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts) {
			Debug.DrawRay(contact.point, contact.normal, Color.white);
			onCollision(contact.otherCollider.gameObject);
		}
	}
}
