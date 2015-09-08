using UnityEngine;
using System.Collections;


public class menu : MonoBehaviour {



	void OnGUI() {

		GUIStyle moj_przycisk = new GUIStyle ("button");
			moj_przycisk.fontSize = ((Screen.height/8)/2);
			moj_przycisk.fontStyle = FontStyle.Italic;
			moj_przycisk.onHover.textColor = Color.black;

	


		if (GUI.Button (new Rect ((Screen.width / 2)-(Screen.width/4), (Screen.height / 2)-(Screen.height/16), Screen.width/2, Screen.height/8), "Rozpocznij przygodę", moj_przycisk)) {
			Application.LoadLevel ("login");
		}
		
		if (GUI.Button (new Rect ((Screen.width / 2)+(Screen.width/4), (Screen.height / 2)+(Screen.height/3), Screen.width/5, Screen.height/8), "Zakończ", moj_przycisk)) {
			Application.Quit();
			Debug.Log ("Quit");
		}
		
	}
}
