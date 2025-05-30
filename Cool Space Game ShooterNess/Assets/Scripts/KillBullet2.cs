using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBullet2 : MonoBehaviour {
	float t = 0f;
	// Use this for initialization
	void Start () {
		StartCoroutine (Kill ());
	}
	void OnTriggerEnter(Collider collider){
		GameObject thingWhatIHit = collider.gameObject;
		if (thingWhatIHit.CompareTag ("Bouncy") && t > 0.2f) {
			transform.rotation = Quaternion.Euler (new Vector3 (0, 180, 0));

		}
		if (thingWhatIHit.CompareTag ("Player2") && t > 0.2f) {
				Destroy (this.gameObject);
		}
		if (thingWhatIHit.CompareTag ("Asstroid")) {
				Destroy (this.gameObject);
		}
		if (thingWhatIHit.CompareTag ("Coral"))
		{
			if (name != "Tank1") {
				Destroy (this.gameObject);
			}
		}
	}
	void OnCollisionEnter(Collision collision)
	{

		/*for( var contact.ContactPoint in info.contacts )
		{
			
			velocity = Quaternion.AngleAxis(180, contact.normal) * transform.forward * -1;
		}*/
	}

	IEnumerator Kill () {
		yield return new WaitForSeconds (3);
		Destroy (this.gameObject);
	}

	void Update() {
		t += Time.deltaTime; 
	}
}
