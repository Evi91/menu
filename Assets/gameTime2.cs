using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;

public class gameTime2 : MonoBehaviour {

	// Use this for initialization
	float x;
	int timeLeft;
	string time1;
	int time2;
	public static string time;
	// Use this for initialization
	void Start () {
		x = 0;
		time1=System.IO.File.ReadAllText("time.txt");
		time2 = int.Parse (time1);
		x = time2;
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
