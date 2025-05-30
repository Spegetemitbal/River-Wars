//this code deletes the shield and starts the shield reserection(in a diferent code)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldNOOOWWW : MonoBehaviour {
	public GameObject Bubble;


	void OnTriggerEnter(Collider collider){
		GameObject thingWhatIHit = collider.gameObject;
		if (thingWhatIHit.CompareTag ("Player") || thingWhatIHit.CompareTag ("Player2")) {
			GameObject g = Instantiate (Bubble, new Vector3 (0, 0, 0), new Quaternion (0, 0, 0, 0));
			g.transform.parent = collider.transform;
			g.transform.localPosition = new Vector3 (0, 0, 0);
			g.transform.localEulerAngles = new Vector3 (0, 0, 0);
			g.transform.localScale = new Vector3 (0.5f,0.5f,0.5f);
			Camera.main.GetComponent<WAIIIIIIT> ().shieldResStart ();
			Destroy (this.gameObject);
		}
	}
}
