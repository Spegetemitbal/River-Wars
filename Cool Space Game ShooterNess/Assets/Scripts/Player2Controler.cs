
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Player2Controler : MonoBehaviour {
	public float speed;
	public float tilt;
	public Boundary boundary;
	public bool CircleDeath = false;
	public bool RapFir = false;
	public bool Speedo = false;
	public bool BadRapFir = false;
	public bool BadSpeedo = false;

	public bool shield = false;
	public bool Badshield = false;

	public AudioClip sound;
	public AudioSource SourceSund;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;

	private float nextFire;

	void Start(){
		name = "PlayerTwo";
		SourceSund.clip = sound;
	}

	void Update ()
	{
		if (RapFir) {
			fireRate = fireRate / 5;
			RapFir = false;
		}
		if (Speedo) {
			speed = speed * 5;
			Speedo = false;
		}
		if (BadRapFir) {
			fireRate = fireRate * 5;
			BadRapFir = false;
		}
		if (BadSpeedo) {
			speed = speed / 5;
			BadSpeedo = false;
		}
		if (Badshield){
			transform.localScale += new Vector3 (2, 2, 2);
			SphereCollider myCollider = transform.GetComponent<SphereCollider>();
			myCollider.radius = myCollider.radius * 2; 
			Badshield = false;
		}
		if (Input.GetButton("Fire2") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			SourceSund.Play ();
			if (CircleDeath) {
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, 15f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, -15f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, 25f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, -25f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, 35f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, -35f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, 45f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, -45f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, 55f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, -55f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, 65f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, -65f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, 75f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, -75f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, 85f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, -85f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, 95f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, -95f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, 105f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, -105f, 0f))));

				CircleDeath = false;
			}
			if (LevelLoader.Treeple1) {
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, 15f, 0f))));
				Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3 (0f, -15f, 0f))));


			}
			//GetComponent<AudioSource>().Play ();
		}

	}
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal2");
		float moveVertical = Input.GetAxis ("Vertical2");
		float shootHorizontal2 = Input.GetAxis ("HorizontalRot2");
		float shootVertical2 = Input.GetAxis ("VerticalRot2");

		if(Mathf.Abs(Input.GetAxis ("HorizontalRot2"))>0.1f || Mathf.Abs(Input.GetAxis ("VerticalRot2"))>0.1f){
			float angle = Mathf.Atan2 (shootHorizontal2, shootVertical2) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.Euler (new Vector3 (90, 0, angle+179));
		}
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		GetComponent<Rigidbody>().velocity = movement * speed;

		GetComponent<Rigidbody>().position = new Vector3
		(
			Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
			0.0f,
			Mathf.Clamp (GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
		);

		//GetComponent<Rigidbody>().rotation = Quaternion.Euler (90, 180.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
	}

	void OnTriggerEnter(Collider collider){
		GameObject thingWhatIHit = collider.gameObject;
		if (shield == false) {
			if (thingWhatIHit.CompareTag ("bulletP")) {
				if (GameObject.Find ("PlayerUno") != null) {
					MenuStart.Scoring2 = true;
					Destroy (this.gameObject);
					Camera.main.GetComponent<HazardSpawner> ().startStop ();
				}
			}
		}
if (shield == false) {
			if (thingWhatIHit.CompareTag ("Asstroid")) {
				if (GameObject.Find ("PlayerUno") != null) {
					MenuStart.Scoring2 = true;
					Destroy (this.gameObject);
					Camera.main.GetComponent<HazardSpawner> ().startStop ();
				}
			}
		}
		if (thingWhatIHit.CompareTag ("Shield")) {
			StartCoroutine (getShield ());
		}
		if (thingWhatIHit.CompareTag ("OpCircleDeath")) {
			CircleDeath = true;
		}
		if (thingWhatIHit.CompareTag ("FireRap")) {
			StartCoroutine (KillRF ());
		}
		if (thingWhatIHit.CompareTag ("Speedy")) {
			StartCoroutine (Spood ());
		}
		if (thingWhatIHit.CompareTag ("BadShield")) {
			StartCoroutine (BadgetShield ());
		}
		if (thingWhatIHit.CompareTag ("BadFireRap")) {
			StartCoroutine (BadKillRF ());
		}
		if (thingWhatIHit.CompareTag ("BadSpeedy")) {
			StartCoroutine (BadSpood ());
		}
	}
	IEnumerator BadSpood (){
		BadSpeedo = true;
		yield return new WaitForSeconds (1);
		speed = speed * 5;
	}
	IEnumerator BadKillRF (){
		BadRapFir = true;
		yield return new WaitForSeconds (1.5f);
		fireRate = fireRate / 5;
	}
	IEnumerator Spood (){
		Speedo = true;
		yield return new WaitForSeconds (1);
		speed = speed / 5;
	}
	IEnumerator KillRF (){
		RapFir = true;
		yield return new WaitForSeconds (1.5f);
		fireRate = fireRate * 5;
	}
	IEnumerator getShield (){
		shield = true;
		yield return new WaitForSeconds (3);
		shield = false;
	}
	IEnumerator BadgetShield (){
		Badshield = true;
		yield return new WaitForSeconds (1.5f);
		transform.localScale += new Vector3 (-2, -2, -2);
		SphereCollider myCollider = transform.GetComponent<SphereCollider>();
		myCollider.radius = myCollider.radius / 2; 
	}
	IEnumerator Lifeness (){
		yield return new WaitForSeconds (0.1f);
		LevelLoader.Life1 = false;
	}
}
