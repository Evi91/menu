using UnityEngine;
using System.Collections;

public class gameTime : MonoBehaviour {
	float x;
	int timeLeft;
	public static string time;
	// Use this for initialization
	void Start () {
		x = 0;
		timeLeft= (int) x;

	}
	
	// Update is called once per frame
	void Update () {
		x += Time.deltaTime;
		timeLeft = (int)x;
	}
	void OnGUI()
	{
		time=timeLeft.ToString();
		GUIStyle literki = new GUIStyle ("Label");
		literki.fontSize = ((Screen.width / 20));
		literki.fontStyle = FontStyle.Bold;
		
		GUI.Label (new Rect (0, 0, 300, 300), "Twój czas: " + time, literki);
	}
}
