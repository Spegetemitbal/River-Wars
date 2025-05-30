using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssTroidRandomizer : MonoBehaviour {
	float speed;
	public bool isCreator;
	public GameObject AssTroid;
	// Use this for initialization
	void Start () {
		if (!isCreator) {
			transform.position = new Vector3 ( 18, 0, Random.Range(-9.5f, 9.5f));
			speed = Random.Range (-6, -10);
		} else {
			StartCoroutine (Cre());
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (!isCreator) {
			transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
			if (transform.position.x < -20) {
				Destroy (this.gameObject);
			}
		}
	}

	IEnumerator Cre () {
		yield return new WaitForSeconds (Random.Range (2, 3));
		Instantiate (AssTroid, transform.position, transform.rotation = Quaternion.Euler (new Vector3 (90, 0, 0)));
		StartCoroutine (Cre());
	}
	void OnTriggerEnter(Collider collider){
		GameObject thingWhatIHit = collider.gameObject;
		if (thingWhatIHit.CompareTag ("bulletP")) {
			Destroy (this.gameObject);			
		}

		if (thingWhatIHit.CompareTag ("bullet")) {
			Destroy (this.gameObject);			
		}
	}
}
