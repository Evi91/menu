using UnityEngine;
using System.Collections;

public class AudioSklep : MonoBehaviour {

	AudioSource platki;
	AudioSource mleko;
	AudioSource spiwor;
	bool[] play= new bool[3];

	// Use this for initialization
	void Start () {
		AudioSource[] audios = GetComponents<AudioSource>();
		platki = audios [0];
		mleko = audios [1];
		spiwor = audios[2];

	
	}
	
	// Update is called once per frame
	void Update () {
		if (Cart.points == 0 && play[Cart.points]==false) {
			platki.Play();
			play[Cart.points]=true;
		}
		if (Cart.points == 1 && play[Cart.points]==false) {
			mleko.Play();
			play[Cart.points]=true;
		}
		if (Cart.points == 2 && play[Cart.points]==false) {
			spiwor.Play();
			play[Cart.points]=true;
		}
	
	}
}
