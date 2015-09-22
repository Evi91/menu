using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;

public class bestTime : MonoBehaviour {

	public string time;
	public int timeInt;
	void Start () {
		time = System.IO.File.ReadAllText("bTime.txt");
		timeInt = int.Parse (time);

	}
	// Use this for initialization
	void OnGUI() {
		
		GUIStyle moj_przycisk = new GUIStyle ("button");
		moj_przycisk.fontSize = ((Screen.height/8)/2);
		moj_przycisk.fontStyle = FontStyle.Italic;
		moj_przycisk.onHover.textColor = Color.black;
		GUIStyle literki = new GUIStyle ("Label");
		literki.fontSize = ((Screen.width / 20));
		literki.fontStyle = FontStyle.Bold;
		
		if(timeInt>0)
			GUI.Label (new Rect ((Screen.width / 2) - (Screen.width / 4), (Screen.height / 2) - (Screen.height / 16), Screen.width / 2, Screen.height / 8), "Najlepszy czas:" + time, literki);
		else
			GUI.Label (new Rect ((Screen.width / 2) - (Screen.width / 4), (Screen.height / 2) - (Screen.height / 16), Screen.width / 2, Screen.height / 8), "Brak wyniku:" + time, literki);
		/*if (GUI.Button (new Rect ((Screen.width / 2)-(Screen.width/4), (Screen.height / 2)-(Screen.height/16), Screen.width/2, Screen.height/8), "Rozpocznij przygodę", moj_przycisk)) {
			Application.LoadLevel ("login");
		}*/
		



		
		if (GUI.Button (new Rect ((Screen.width / 2)+(Screen.width/4), (Screen.height / 2)+(Screen.height/3), Screen.width/5, Screen.height/8) , "Powrot" , moj_przycisk)) {
			Application.Quit();
			Debug.Log ("menu_scene");
		}
		if (GUI.Button (new Rect ((Screen.width / 2)-(Screen.width/2), (Screen.height / 2)+(Screen.height/3), Screen.width/5, Screen.height/8), "Zakończ", moj_przycisk)) {
			Application.Quit();
			Debug.Log ("Quit");
		}

	}
}