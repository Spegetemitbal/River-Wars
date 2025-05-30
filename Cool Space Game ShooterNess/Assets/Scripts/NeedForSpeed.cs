//this spawns the charactor also its connected with ButtonPressing
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedForSpeed : MonoBehaviour{
	public static bool Life = false;
	public static bool Life1 = false;
	public static bool Treeple = false;
	public static bool Treeple1 = false;
	bool NFS;
	bool TK;
	bool Tri;
	bool BC;
	bool LAZ;
	bool CHA;
	bool NFS2;
	bool Tri2;
	bool TK2;
	bool BC2;
	bool LAZ2;
	bool CHA2;

	//for spawning the player
	public GameObject NeedFS;
	public GameObject Tank;
	public GameObject BigC;
	public GameObject TripleS;
	public GameObject Lazer;
	public GameObject Charg;
	public GameObject NeedFS1;
	public GameObject Tank1;
	public GameObject BigC1;
	public GameObject TripleS1;
	public GameObject Lazer1;
	public GameObject Charg1;

	//figures out witch button was pressed in ButtonPressing
	void Start() {
		Treeple = false;
		Treeple1 = false;
		if (PlayerPrefs.GetInt ("NFSeent") == 1) {
			NFS = true;
		} else {
			NFS = false;
		}
		if (PlayerPrefs.GetInt ("BigCaneent") == 1) {
			BC = true;
		} else {
			BC = false;
		}
		if (PlayerPrefs.GetInt ("Tripleeent") == 1) {
			Tri = true;
			Treeple = true;
		} else {
			Tri = false;
		}
		if (PlayerPrefs.GetInt ("Tankeent") == 1) {
			TK = true;
			Life = true;
		} else {
			TK = false;
		}
		if (PlayerPrefs.GetInt ("Lazereent") == 1) {
			LAZ = true;
		} else {
			LAZ = false;
		}
		if (PlayerPrefs.GetInt ("Chargereent") == 1) {
			CHA = true;
		} else {
			CHA = false;
		}
		if (PlayerPrefs.GetInt ("NFS2eent") == 1) {
			if (PlayerPrefs.GetInt ("TowerD") == 1) {
				NFS2 = false;
			} else {
				NFS2 = true;
			}
		} else {
			NFS2 = false;
		}
		if (PlayerPrefs.GetInt ("BigCan2eent") == 1) {
			if (PlayerPrefs.GetInt ("TowerD") == 1) {
				BC2 = false;
			} else {
				BC2 = true;
			}
		} else {
			BC2 = false;
		}
		if (PlayerPrefs.GetInt ("Triple2eent") == 1) {
			if (PlayerPrefs.GetInt ("TowerD") == 1) {
				Tri2 = false;
				Treeple1 = false;
			} else {
				Tri2 = true;
				Treeple1 = true;
			}
		} else {
			Tri2 = false;
		}
		if (PlayerPrefs.GetInt ("Tank2eent") == 1) {
			if (PlayerPrefs.GetInt ("TowerD") == 1) {
				TK2 = false;
				Life1 = false;
			} else {
				TK2 = true;
				Life1 = true;
			}
		} else {
			TK2 = false;
		}
		if (PlayerPrefs.GetInt ("Lazer2eent") == 1) {
			if (PlayerPrefs.GetInt ("TowerD") == 1) {
				LAZ2 = false;
			} else {
				LAZ2 = true;
			}
		} else {
			LAZ2 = false;
		}
		if (PlayerPrefs.GetInt ("Charger2eent") == 1) {
			if (PlayerPrefs.GetInt ("TowerD") == 1) {
				CHA2 = false;
			} else {
				CHA2 = true;
			}
		} else {
			CHA2 = false;
		}
		//instantiates witch player was chosen
		if (NFS){
			Instantiate (NeedFS, NeedFS.transform.position, NeedFS.transform.rotation);
		}
		if (BC){
			Instantiate (BigC, BigC.transform.position, BigC.transform.rotation);
		}
		if (Tri){
			Instantiate (TripleS, TripleS.transform.position, TripleS.transform.rotation);
		}
		if (TK){
			Instantiate (Tank, Tank.transform.position, Tank.transform.rotation);
		}
		if (LAZ){
			Instantiate (Lazer, Lazer.transform.position, Lazer.transform.rotation);
		}
		if (CHA){
			Instantiate (Charg, Charg.transform.position, Charg.transform.rotation);
		}
		if (NFS2){
			Instantiate (NeedFS1, NeedFS1.transform.position, NeedFS1.transform.rotation);
		}
		if (BC2){
			Instantiate (BigC1, BigC1.transform.position, BigC1.transform.rotation);
		}
		if (Tri2){
			Instantiate (TripleS1, TripleS1.transform.position, TripleS1.transform.rotation);
		}
		if (TK2){
			Instantiate (Tank1, Tank1.transform.position, Tank1.transform.rotation);
		}
		if (LAZ2){
			Instantiate (Lazer1, Lazer1.transform.position, Lazer1.transform.rotation);
		}
		if (CHA2){
			Instantiate (Charg1, Charg1.transform.position, Charg1.transform.rotation);
		}
	}
}