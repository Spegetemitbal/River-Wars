using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TowerScore : MonoBehaviour {
	public static Text WinScore;
	public static int TimeS;
	public static int ObjS;

	/*public void Start(){
		if (GameObject.Find ("StartObject") == null) {
			name = "StartObject";
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}
		TimeS = PlayerPrefs.GetInt ("Time", 0);
		ObjS = PlayerPrefs.GetInt ("Obj", 0);
	}
	//this is lucases
	void Update(){
		if (SceneManager.GetActiveScene ().name == "S.M.O.G") {
			WinScore = GameObject.Find ("Score").GetComponent<Text> ();
			WinScore.text = TimeS "\n\n" ObjS;
		}
		PlayerPrefs.SetInt ("Time", TimeS);
		PlayerPrefs.SetInt ("Obj", ObjS);
	}
*/}
