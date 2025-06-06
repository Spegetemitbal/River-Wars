//bullet kill code (pretty easy to understand)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBullet : MonoBehaviour {
	float t = 0f;
	// Use this for initialization
	void Start () {
		StartCoroutine (Kill ());
	}
	void OnTriggerEnter(Collider collider){
		GameObject thingWhatIHit = collider.gameObject;
		if (thingWhatIHit.CompareTag ("Bouncy") && t > 0.2f) {
			Rigidbody rb = GetComponent<Rigidbody>();
			Vector3 reflectionNormal = collider.transform.right;
			if (Vector3.Dot(reflectionNormal, transform.forward) >= 90)
			{
				reflectionNormal = -reflectionNormal;
			}
            rb.velocity = Vector3.Reflect(rb.velocity, reflectionNormal);
            var headingChange = Quaternion.FromToRotation(transform.forward, Vector3.Normalize(rb.velocity));
			transform.rotation *= headingChange;
        }
		if (thingWhatIHit.CompareTag ("Player") && t > 0.2f) {
				Destroy (this.gameObject);

		}
		if (thingWhatIHit.CompareTag ("Asstroid")) {
				Destroy (this.gameObject);
	 	}
		if (name != "Tank||Tank1") {
			if (thingWhatIHit.CompareTag ("Coral")) {
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