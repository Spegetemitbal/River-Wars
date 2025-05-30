using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eleck : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (DeD());
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation *= Quaternion.Euler (new Vector3 (0, 120, 0));
		transform.localScale += new Vector3 (0.2f, 0.2f, 0.2f);
		SphereCollider myCollider = transform.GetComponent<SphereCollider>();
		myCollider.radius += 0.002f;
	}

	IEnumerator DeD(){
		yield return new WaitForSeconds (1);
		Destroy (this.gameObject);
	}
}
