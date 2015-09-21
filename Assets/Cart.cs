using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Cart : MonoBehaviour {
	public static bool scene2=false;

	public static int points = 0;
	//public static float isIn = 0;
	public static bool goPowder=false;
	//public GameObject cart;


	List<GameObject> collected = new List<GameObject> ();


	public void SwipeRight ()
	{
		//Debug.Log ("Swipe right started");
		if (points == 5 && Shelf.howManySwipe==2) {
			points=6;
			StartAnim1 ();


			//Debug.Log ("Animation started");
		}
	}
	// Use this for initialization
	void Start () {
		scene2 = true;
	
	}

	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter(Collider colide)
	{
		GameObject now = colide.gameObject;

		if (!collected.Contains (now) && now.tag == "valuable") {
			collected.Add (now);
			points = collected.Count;
			//Debug.Log ("Zebrano obiekt: " + now.name + " Punktacja: " + points);
		} else {
			//Debug.Log("Objekt jest juz zebrany: " + now.name);
		}


	}

	bool isAnimation1 = false;

	public void StartAnim1()
	{
		if (isAnimation1)
			return;
		
		StartCoroutine(MoveAnim1());
		isAnimation1 = true;
	}

	IEnumerator MoveAnim1()
	{
		while (true) {
			if (transform.position.z > 12.1f) break;
			transform.position = transform.position + new Vector3 (0, 0, 1) * Time.deltaTime;
			yield return new WaitForEndOfFrame();
		}
		isAnimation1= false;
		goPowder = true;
	}

	void OnGUI()
	{
		GUIStyle literki = new GUIStyle ("Label");
		literki.fontSize = ((Screen.width / 20));
		literki.fontStyle = FontStyle.Bold;

		GUI.Label (new Rect (0, 0, 300, 300), "Pkt: " + points, literki);
	}
}
