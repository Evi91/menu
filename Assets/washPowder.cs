using UnityEngine;
using System.Collections;

public class washPowder : MonoBehaviour {

	// Use this for initialization
	public static bool isPowderIn = false;
	public GameObject powderL;
	public GameObject powderR;


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Cart.goPowder)
			StartAnim1 ();

	
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
			if (transform.position.z < 6.8f) break;
			transform.position = transform.position + new Vector3 (0, 0, -3) * Time.deltaTime;
			yield return new WaitForEndOfFrame();

		}
		isAnimation1= false;
		isPowderIn = true;
	}

	void onColisionEnter(Collision collision)
	{
		Cart.points++;
	}

}
