
//this is mostly all mine i have a few that i got off my brother or internet that was modifide a bit but this just a littl of my code.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour {

	bool isSecondPlayer = false;
	string oppositeTag = "Player2";
	string oppositeBullet = "bulletP";
	string bulletTag = "bullet";

	//If you're hit with a triple shot, you're open to die immediately if weakened is true.
	bool weakened = false;
	//For IFrames.
	bool invincible = false;

	public int playerIndex = 0;
	public Vector2 moveAxis = Vector2.zero;
	public bool isShooting = false;

	public float speed;
	public float tilt;
	public Boundary boundary;	
	public bool CircleDeath = false;
	public bool RapFir = false;
	public bool Speedo = false;
	public bool BadRapFir = false;
	public bool BadSpeedo = false;
	public bool TripleShot = false;

	public AudioClip sound;
	public AudioSource SourceSund;


	public bool shield = false;
	public bool Badshield = false;

	public GameObject shot;
	public Transform shotSpawn;
	Rigidbody rb;
	SphereCollider sphereCol;
	public float fireRate;

	private float nextFire;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
		sphereCol = GetComponent<SphereCollider>();
    }

    public void SetSecondPlayer(bool isSecondPlayert)
	{
		if (isSecondPlayert)
		{
			tag = "Player2";
			oppositeTag = "Player";
			oppositeBullet = "bullet";
			bulletTag = "bulletP";
		}
		else
		{
			tag = "Player";
			oppositeTag = "Player2";
			oppositeBullet = "bulletP";
			bulletTag = "bullet";
		}
		this.isSecondPlayer = isSecondPlayert;
	}

	//this is were it shoots and spawns the bullet
	void Update ()
	{
		if (RapFir) {
			fireRate /= 5;
			RapFir = false;
		}
		if (Speedo) {
			speed *= 5;
			Speedo = false;
		}
		if (BadRapFir) {
			fireRate *= 5;
			BadRapFir = false;
		}
		if (BadSpeedo) {
			speed /= 5;
			BadSpeedo = false;
		}
		if (Badshield){
			transform.localScale += new Vector3 (2, 2, 2);
			sphereCol.radius = sphereCol.radius * 2; 
			Badshield = false;
		}
		if (isShooting)
		{
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject b1 = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                b1.tag = bulletTag;
                //SourceSund.Play ();
                if (CircleDeath)
                {

                    for (int i = 0; i < 10; i++)
                    {
                        GameObject b2 = Instantiate(shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3(0f, 15f + ((float)i * 10), 0f))));
                        GameObject b3 = Instantiate(shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3(0f, -15f + ((float)i * -10), 0f))));
                        b2.tag = bulletTag;
                        b3.tag = bulletTag;
                    }

                    CircleDeath = false;
                }
                else if (TripleShot)
                {
                    GameObject b2 = Instantiate(shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3(0f, 15f, 0f))));
                    GameObject b3 = Instantiate(shot, shotSpawn.position, Quaternion.Euler(shotSpawn.eulerAngles + (new Vector3(0f, -15f, 0f))));
                    b2.tag = bulletTag;
                    b3.tag = bulletTag;
                }
                //GetComponent<AudioSource>().Play ();
            }
			isShooting = false;
        }
	}
	void FixedUpdate ()
	{
		//this is all the movement and rotation code

		Vector3 movement = new Vector3 (moveAxis.x, 0.0f, moveAxis.y);
		rb.velocity = movement * speed;
		if (rb.velocity.magnitude > 0.1f)
		{
			float angle = Mathf.Atan2(moveAxis.x, moveAxis.y) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.Euler(new Vector3(90, 0, -angle));
        }

        rb.position = new Vector3(
			Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax),
			0.0f,
			Mathf.Clamp (rb.position.z, boundary.zMin, boundary.zMax)
		);

		//GetComponent<Rigidbody> ().rotation = Quaternion.Euler (90, 0.0f, GetComponent<Rigidbody> ().velocity.x * -tilt);
	}
	//DEATH TO ALL players
	void OnTriggerEnter(Collider collider){
		GameObject thingWhatIHit = collider.gameObject;
		if (shield == false) {
			if (thingWhatIHit.CompareTag (oppositeBullet)) {
				if (GameObject.FindGameObjectWithTag(oppositeTag) != null) {
					if (collider.name == "Triple Shot")
					{
						if (!weakened)
						{
							weakened = true;
						} else
						{
							Die();
                        }
					} else
					{
						Die();
                    }
				}
			}
		}
if (shield == false){
			if (thingWhatIHit.CompareTag ("Asstroid")) {
				if (GameObject.FindGameObjectWithTag(oppositeTag) != null) {
					Die();
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
		//this is were the tank and shield is
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
		sphereCol.radius = sphereCol.radius / 2; 
	}
	IEnumerator Lifeness (){
		yield return new WaitForSeconds (0.25f);
		LevelLoader.Life = false;
	}


	void Die()
	{
        MenuStart.Scoring = true;
        Destroy(this.gameObject);
        Camera.main.GetComponent<HazardSpawner>().startStop();
    }
}