using UnityEngine;
using System.Collections;

public class keyboards : MonoBehaviour {
	 
	string stringToEdit = "Wpisz login";
	string pomocnicza="";
	void OnGUI(){


		int x = (Screen.width / 8);
		int y = (Screen.height/ 3);
		int a = System.Convert.ToInt32('A');
		int z = System.Convert.ToInt32('Z');
		char letter;


		GUIStyle literki = new GUIStyle ("button");
			literki.fontSize = ((Screen.width / 10)/5);
			literki.fontStyle = FontStyle.Bold;

		stringToEdit = GUI.TextField(new Rect(Screen.width /3, Screen.width / 30, Screen.width /3, Screen.height /6), stringToEdit, 15, literki);


		for (int i =a; i<=z; i++) {

			letter= System.Convert.ToChar(i);
			if (GUI.Button (new Rect (x,y, (Screen.width / 18), (Screen.width / 18)), ""+letter+"", literki)) {

				char lit=System.Convert.ToChar(i);


				pomocnicza= pomocnicza+System.Convert.ToChar(i);
				stringToEdit=pomocnicza;
			}

			x=x+(Screen.width / 11);
			
			if(x < ((Screen.width / 15)*14)-(Screen.width / 15))
			{

			}
			else
			{
				x= (Screen.width / 10);
				y=y+(Screen.width / 11);
			}


		}

		if (GUI.Button (new Rect (Screen.width /50, Screen.width / 30, Screen.width/6, Screen.height/6), "Do menu", literki)) {
			Application.LoadLevel ("menu_scena");
		}

		if (GUI.Button (new Rect (Screen.width /30+((Screen.width /30)*23), Screen.width / 30, Screen.width/6, Screen.height/6), "Graj", literki)) {
			Application.LoadLevel ("scena1");
		}
		if (GUI.Button (new Rect ((Screen.width / 2)+(Screen.width/4), (Screen.height / 2)+(Screen.height/3), Screen.width/5, Screen.height/8), "Zakończ", literki)) {
			Application.Quit();
			Debug.Log ("Quit");
		}
	}


}






