using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Moslty lucas's

public class EnemyMove : MonoBehaviour {
	bool atPos;
	public float Speed = 10;
	Vector3 nextPos;
	public GameObject shot;
	bool canShoot;
	// Use this for initialization
	void Start () {
		nextPos = new Vector3 (Random.Range (-6, 6), 0, 9);
		canShoot = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (atPos) {
			if (canShoot) {
				StartCoroutine (Shoot ());
			} else {
				transform.LookAt (GameObject.Find ("Player").transform.position);
			}
		} else {
			transform.LookAt (nextPos);
			transform.position = Vector3.Lerp (transform.position,nextPos,Speed * Time.deltaTime);
		}
		if (Vector3.Distance (transform.position, nextPos) < 0.5f) {
			atPos = true;
		} else {
			atPos = false;
		}
		if (transform.position.z < -10.5f) {
			transform.position = new Vector3 (0, 0, 10.5f);
			nextPos = new Vector3 (Random.Range (-6, 6), 0, 9);
		}
	}

	IEnumerator Shoot () {
		canShoot = false;
		transform.LookAt (GameObject.Find ("Player").transform.position);
		Instantiate(shot, transform.position+transform.forward, transform.rotation);
		yield return new WaitForSeconds (2);
		nextPos = new Vector3 (Random.Range (-6, 6), 0, nextPos.z - 3);
		canShoot = true;
	}
	/*void OnTriggerEnter(Collider collider){
		GameObject thingWhatIHit = collider.gameObject;
		if (thingWhatIHit.CompareTag ("bulletP")) {
			Destroy (this.gameObject);			
		}
	}*/
}
