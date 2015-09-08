using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	private static LevelManager instance;

	public static LevelManager Instance
	{
		get { return instance; }
	}

	public bool isCollected = false;

	void Awake(){
		instance = this;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
