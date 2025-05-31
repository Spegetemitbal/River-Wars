//this spawns the charactor also its connected with ButtonPressing
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditorInternal;
using UnityEngine;

public class LevelLoader : MonoBehaviour{
	public static bool Life = false;
	public static bool Life1 = false;
	public static bool Treeple = false;
	public static bool Treeple1 = false;

	//for spawning the player
	public GameObject Tadpole;
	public GameObject Aura;
	public GameObject Beetle;
	public GameObject TripleShot;
	public GameObject Lazer;
	public GameObject Charger;

	List<GameObject> listThingie = new List<GameObject>();

	public Transform SpawnPoint1, SpawnPoint2;

    private void Awake()
    {

		listThingie.Add(Tadpole);
        listThingie.Add(Charger);
        listThingie.Add(Beetle);
        listThingie.Add(Aura);
		listThingie.Add(Lazer);
		listThingie.Add(TripleShot);


		PlayerController p1 = Instantiate(listThingie[(int)SelectionData.p1Class], SpawnPoint1.position, SpawnPoint1.rotation).GetComponent<PlayerController>();
		p1.SetSecondPlayer(false);
        if (SelectionData.currentGameMode == GameModes.Brawl)
		{
			PlayerController p2 = Instantiate(listThingie[(int)SelectionData.p2Class], SpawnPoint2.position, SpawnPoint2.rotation).GetComponent<PlayerController>();
			p2.SetSecondPlayer(true);
		} 
    }

}