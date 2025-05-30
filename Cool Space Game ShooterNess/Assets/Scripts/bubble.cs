using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubble : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (boobleD ());
	}

	public IEnumerator boobleD(){
		yield return new WaitForSeconds (2.5f);
		Destroy (this.gameObject);
	}
}
