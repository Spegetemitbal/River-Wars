using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtons : MonoBehaviour {

	void Start(){
		SelectionData.currentGameMode = GameModes.Brawl;
	}

	void TowerStart(){
		SelectionData.currentGameMode = GameModes.TowerDefense;
	}

	public void changemenuscene(string scenename){
		SceneManager.LoadScene(scenename);
	}

	public void Quit(){
		Application.Quit();
	}

	void ResetScore(){
		MenuStart.Plr1S = 0;
		MenuStart.Plr2S = 0;
		PlayerPrefs.DeleteAll ();
	}
	public void Settings(string scenename){
        SceneManager.LoadScene(scenename);
    }
	public void Credits(string scenename){
        SceneManager.LoadScene(scenename);
    }
}
