//this code does a few diferent things like shield reserection and the other comment tells you more
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WAIIIIIIT : MonoBehaviour {
	public static bool Bad = false;
	public GameObject ShieldThing;
	public GameObject OpCircle;
	public GameObject BoyoFire;
	public GameObject Speedy;
	public GameObject BadShieldThing;
	public GameObject BadOpCircle;
	public GameObject BadBoyoFire;
	public GameObject BadSpeedy;
	public int WhatSp = 0;
	public int WhatSp2 = 0;
	public int WhatSp3 = 0;
	public int WhatSp4 = 0;
	public int Scary = 0;

	public void Start(){
		shieldResStart ();
		StartCoroutine (Circle ());
		StartCoroutine (RapidF ());
		StartCoroutine (Speedness ());
	}

	public void DeathCircle(){
		StartCoroutine (Circle ());
	}

	public void Speeder(){
		StartCoroutine (Speedness ());
	}

	public void Rfire(){
		StartCoroutine (RapidF ());
	}

	public void shieldResStart(){
		StartCoroutine (shieldRes ());
	}

	public IEnumerator shieldRes(){
		Bad = false;
		yield return new WaitForSeconds (Random.Range(3f,8f));
		WhatSp = Random.Range (1 , 10);
		if (WhatSp < 7.5f) {
			Instantiate (ShieldThing, new Vector3 (Random.Range (-16, 16), 0, Random.Range (-9, 9)), transform.rotation);
		} else {
			if (!Bad) {
				Instantiate (BadShieldThing, new Vector3 (Random.Range (-16, 16), 0, Random.Range (-9, 9)), transform.rotation);
				Bad = true;
			} else {
				Instantiate (ShieldThing, new Vector3 (Random.Range (-16, 16), 0, Random.Range (-9, 9)), transform.rotation);
			}
		}
	}

	public IEnumerator Speedness(){
		Bad = false;
		yield return new WaitForSeconds (Random.Range(3f,8f));
		WhatSp2 = Random.Range (1 , 10);
		if (WhatSp2 < 7.5f) {
			Instantiate (Speedy, new Vector3 (Random.Range (-16, 16), 0, Random.Range (-9, 9)), transform.rotation);
		} else {
			if (!Bad) {
				Instantiate (BadSpeedy, new Vector3 (Random.Range (-16, 16), 0, Random.Range (-9, 9)), transform.rotation);
				Bad = true;
			} else {
				Instantiate (Speedy, new Vector3 (Random.Range (-16, 16), 0, Random.Range (-9, 9)), transform.rotation);
			}
		}
	}

	public IEnumerator RapidF(){
		Bad = false;
		yield return new WaitForSeconds (Random.Range(3f,8f));
		WhatSp3 = Random.Range (1 , 10);
		if (WhatSp3 < 7.5f) {
			Instantiate (BoyoFire, new Vector3 (Random.Range (-16, 16), 0, Random.Range (-9, 9)), transform.rotation);
		} else {
			if (!Bad) {
				Instantiate (BadBoyoFire, new Vector3 (Random.Range (-16, 16), 0, Random.Range (-9, 9)), transform.rotation);
				Bad = true;
			} else {
				Instantiate (BoyoFire, new Vector3 (Random.Range (-16, 16), 0, Random.Range (-9, 9)), transform.rotation);
			}
		}
	}

	public IEnumerator Circle(){
		yield return new WaitForSeconds (Random.Range(3f,8f));
			Instantiate (OpCircle, new Vector3 (Random.Range (-16, 16), 0, Random.Range (-9, 9)), transform.rotation);
	}

	public void startStop(){
		StartCoroutine (stop());
	}
	//this is for deactivating triple shot and tank after the game ends
	public IEnumerator stop(){
		yield return new WaitForSeconds (1);
		NeedForSpeed.Treeple = false;
		NeedForSpeed.Treeple1 = false;
		NeedForSpeed.Life = false;
		NeedForSpeed.Life1 = false;
		Application.LoadLevel("S.M.O.G");
	}
	public void Smog(string scenename){
		Application.LoadLevel(scenename);
	}
	public void Eggkill(){
			Application.LoadLevel("S.M.O.G");
	}
}