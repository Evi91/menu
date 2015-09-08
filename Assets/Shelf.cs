using UnityEngine;
using System.Collections;

public class Shelf : MonoBehaviour 
{
	public static int howManySwipe = 0;

	//public GameObject wozek;
	public void SwipeLeft ()
	{
		if (Cart.points == 2) {
			StartAnim1 ();
			howManySwipe=1;
			//Debug.Log ("Animation started");
		}

		if (Cart.points == 4) {
			StartAnim2 ();
			howManySwipe=2;
			//Debug.Log ("Animation started");
		}
		if (howManySwipe == 2 && Cart.points == 4)
			Cart.points = 5;
	}

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
	}

	bool isAnimation1 = false;
	bool isAnimation2 = false;
	public void StartAnim1()
	{
		if (isAnimation1)
			return;

		StartCoroutine(MoveAnim1());
		isAnimation1 = true;
	}

	public void StartAnim2()
	{
		if (isAnimation2)
			return;
		
		StartCoroutine(MoveAnim2());
		isAnimation2 = true;
	}

	IEnumerator MoveAnim1()
	{
		while (true) {
			if (transform.position.x > 2.1f) break;
			transform.position = transform.position + new Vector3 (1, 0, 0) * Time.deltaTime;
			yield return new WaitForEndOfFrame();
		}
		isAnimation1= false;
	}

	IEnumerator MoveAnim2()
	{
		while (true) {
			if (transform.position.x > 4.2f) break;
			transform.position = transform.position + new Vector3 (1, 0, 0) * Time.deltaTime;
			yield return new WaitForEndOfFrame();
		}


		isAnimation2= false;
	}
}
