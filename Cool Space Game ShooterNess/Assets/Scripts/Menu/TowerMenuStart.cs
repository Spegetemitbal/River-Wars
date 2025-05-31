//loads the class choose, settings, and quiting the game
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TowerMenuStart : MonoBehaviour {
	public static Text WinScore;
	public static int AssTroidS;
	public static bool Scoring = false;

	public void Start(){
		if (GameObject.Find ("StartObject") == null) {
			name = "StartObject";
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}
	}

	void TroiPoints(){
		++TowerMenuStart.AssTroidS;
	}
	//this is lucases
	void Update(){
		if (Scoring) {
			TroiPoints ();
			Scoring = false;
		}
	
		if (SceneManager.GetActiveScene ().name == "Tower End") {
			WinScore = GameObject.Find ("Score").GetComponent<Text> ();
		//	WinScore.text = AssTroidS;
		}
	}
}
