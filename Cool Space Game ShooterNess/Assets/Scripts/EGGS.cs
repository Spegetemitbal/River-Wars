﻿//this is for towers of eggs that will die when astroids hit it
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EGGS : MonoBehaviour {
	public Animator anim;
	int life = 3;
	int life1 = 3;

	void Update(){
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider collider){
		
		GameObject thingWhatIHit = collider.gameObject;
			if (gameObject.name == "EGGSY") {
			if (life < 1) {
				if (thingWhatIHit.CompareTag ("Asstroid")) {
					Camera.main.GetComponent<HazardSpawner> ().Eggkill ();
					StartCoroutine (Killdis());
				}
			} else {
				if (thingWhatIHit.CompareTag ("Asstroid")) {
					StartCoroutine (death ());
				}
			}
		}
		if (gameObject.name == "EGGSY1"){
			if (life1 < 1) {
				if (thingWhatIHit.CompareTag ("Asstroid")) {
					Camera.main.GetComponent<HazardSpawner> ().Eggkill ();
					StartCoroutine (Killdis1());
				}
			} else {
				if (thingWhatIHit.CompareTag ("Asstroid")) {
					StartCoroutine (death1 ());
				}
			}
		}
	}

	IEnumerator death(){
		anim.Play ("Hurt");
		yield return new WaitForSeconds (0.4f);
		life--;
	}

     public IEnumerator death1(){
		anim.Play ("Hurt");
		yield return new WaitForSeconds (0.4f);
		life1--;
	}
	public IEnumerator Killdis1(){
		anim.Play ("Eggsy ness");
		yield return new WaitForSeconds (1);
		Destroy (GameObject.Find ("EGGSY1"));
	}
	public IEnumerator Killdis(){
		anim.Play ("Eggsy ness");
		yield return new WaitForSeconds (1);
		Destroy (GameObject.Find ("EGGSY"));
	}
}
