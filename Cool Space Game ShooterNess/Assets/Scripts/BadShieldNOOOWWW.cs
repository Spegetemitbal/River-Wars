using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadShieldNOOOWWW : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
		GameObject thingWhatIHit = collider.gameObject;
		if (thingWhatIHit.CompareTag ("Player") || thingWhatIHit.CompareTag ("Player2")) {
			Camera.main.GetComponent<WAIIIIIIT> ().shieldResStart ();
			Destroy (this.gameObject);
		}
	}
}
