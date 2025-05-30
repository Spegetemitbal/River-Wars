//this and NeedForSpeed are connected and this is charactor selection 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressing : MonoBehaviour {
	public static bool TD;
	public int NFSint = 0;
	public int Tankint = 0;
	public int BigCanint = 0;
	public int Tripleint = 0;
	public int Lazerint = 0;
	public int Chargerint = 0;
	public int NFS2int = 0;
	public int Tank2int = 0;
	public int BigCan2int = 0;
	public int Triple2int = 0;
	public int Lazer2int = 0;
	public int Charger2int = 0;

	public bool playertwo = false;

	//this was becouse of glitches with playerpref
	IEnumerator wait(){
		yield return new WaitForSeconds (0.1f);
		NFSint = 0;
	    Tankint = 0;
	    BigCanint = 0;
	    Tripleint = 0;
		Lazerint = 0;
		Chargerint = 0;
	    NFS2int = 0;
	    Tank2int = 0;
	    BigCan2int = 0;
	    Triple2int = 0;
		Lazer2int = 0;
		Charger2int = 0;
		playertwo = true;
	}
	//all of these are seeing witch button was pressed and telling things to the bottom of the code
	void Press1 () {
		if (!playertwo) {
			NFSint = 1;
			PlayerPrefs.SetInt ("NFSeent", NFSint);
			StartCoroutine (wait ());
		}	
	}
	void Press2 () {
		if (!playertwo) {
			Tankint = 1;
			PlayerPrefs.SetInt ("Tankeent", Tankint);
			StartCoroutine (wait ());
		}
	}
	void Press3 () {
		if (!playertwo) {
			BigCanint = 1;
			PlayerPrefs.SetInt("BigCaneent", BigCanint);
			StartCoroutine (wait());
		}
	}
	void Press4 () {
		if (!playertwo) {
			Tripleint = 1;
			PlayerPrefs.SetInt ("Tripleeent", Tripleint);
			StartCoroutine (wait ());
		}
	}
	void Press5 () {
		if (!playertwo) {
			Lazerint = 1;
			PlayerPrefs.SetInt ("Lazereent", Lazerint);
			StartCoroutine (wait ());
		}
	}
	void Press6 () {
		if (!playertwo) {
			Chargerint = 1;
			PlayerPrefs.SetInt ("Chargereent", Chargerint);
			StartCoroutine (wait ());
		}
	}
	void Press12 () {
		if (playertwo) {
			NFS2int = 1;
			PlayerPrefs.SetInt ("NFS2eent", NFS2int);
			if (TD) {
				int Num = Random.Range (1, 33);
				Application.LoadLevel ("1V"+Num);
			} else {
				Application.LoadLevel ("Tower Defence");
			}
		}
	}
	void Press22 () {
		if (playertwo) {
			Tank2int = 1;
			PlayerPrefs.SetInt ("Tank2eent", Tank2int);
			if (TD) {
				int Num = Random.Range (1, 33);
				Application.LoadLevel ("1V"+Num);
			} else {
				Application.LoadLevel ("Tower Defence");
			}
		}
	}
	void Press32 () {
		if (playertwo) {
			BigCan2int = 1;
			PlayerPrefs.SetInt ("BigCan2eent", BigCan2int);
			if (TD) {
				int Num = Random.Range (1, 33);
				Application.LoadLevel ("1V"+Num);
			} else {
				Application.LoadLevel ("Tower Defence");
			}		
		}
	}
	void Press42 () {
		if (playertwo) {
			Triple2int = 1;
			PlayerPrefs.SetInt ("Triple2eent", Triple2int);
			if (TD) {
				int Num = Random.Range (1, 33);
				Application.LoadLevel ("1V"+Num);
			} else {
				Application.LoadLevel ("Tower Defence");
			}		
		}
		//seting the integer for the choosing in NeedForSpeed
	}
	void Press52 () {
		if (playertwo) {
			Lazer2int = 1;
			PlayerPrefs.SetInt ("Lazer2eent", Lazer2int);
			if (TD) {
				int Num = Random.Range (1, 33);
				Application.LoadLevel ("1V"+Num);
			} else {
				Application.LoadLevel ("Tower Defence");
			}		
		}
	}
	void Press62 () {
		if (playertwo) {
			Charger2int = 1;
			PlayerPrefs.SetInt ("Charger2eent", Charger2int);
			if (TD) {
				int Num = Random.Range (1, 33);
				Application.LoadLevel ("1V"+Num);
			} else {
				Application.LoadLevel ("Tower Defence");
			}		
		}
	}
	void Start(){
		PlayerPrefs.SetInt("NFSeent", 0);
		PlayerPrefs.SetInt("BigCaneent", 0);
		PlayerPrefs.SetInt("Tankeent", 0);
		PlayerPrefs.SetInt("Tripleeent", 0);
		PlayerPrefs.SetInt("Lazereent", 0);
		PlayerPrefs.SetInt("Chargereent", 0);
		PlayerPrefs.SetInt("NFS2eent", 0);
		PlayerPrefs.SetInt("BigCan2eent", 0);
		PlayerPrefs.SetInt("Tank2eent", 0);
		PlayerPrefs.SetInt("Triple2eent", 0);
		PlayerPrefs.SetInt("Lazer2eent", 0);
		PlayerPrefs.SetInt("Charger2eent", 0);
	}
	void TDistrue(){
		if (PlayerPrefs.GetInt ("TowerD") == 1) {
			TD = false;
		}else{
			TD = true;
		}
	}
}
