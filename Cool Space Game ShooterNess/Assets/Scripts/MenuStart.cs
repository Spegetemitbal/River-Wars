//loads the class choose, settings, and quiting the game
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuStart : MonoBehaviour {
	public static Text WinScore;
	public static int Plr1S;
	public static int Plr2S;
	public static bool Scoring = false;
	public static bool Scoring2 = false;

	public void Start(){
		if (GameObject.Find ("StartObject") == null) {
			name = "StartObject";
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}
	}

	void Points(){
		++MenuStart.Plr2S;
	}
	void Points2(){
		++MenuStart.Plr1S;
	}
	//this is lucases
	void Update(){
		if (Scoring) {
			Points ();
			Scoring = false;
		}
		if (Scoring2) {
			Points2 ();
			Scoring2 = false;
		}
	
		if (SceneManager.GetActiveScene ().name == "S.M.O.G") {
			WinScore = GameObject.Find ("Score").GetComponent<Text> ();
			WinScore.text = "Top\n" + Plr2S + "\nBottom\n" + Plr1S;
		}
		PlayerPrefs.SetInt ("Pl1Win", Plr1S);
		PlayerPrefs.SetInt ("Pl2win", Plr2S);
	}
}
