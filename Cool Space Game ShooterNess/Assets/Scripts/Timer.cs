//once a player is dead it will start this code and load the start screen after 5 seconds
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	public void  Wait5(){
		Camera.main.GetComponent<Timer>().Wait5();
		StartCoroutine (LoadAfterDelay ());
	}

	public IEnumerator LoadAfterDelay(){
		yield return new WaitForSeconds(05); // wait 5 seconds
		Application.LoadLevel("S.M.O.G");

	}
}