//this and NeedForSpeed are connected and this is charactor selection 
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPressing : MonoBehaviour {

	public bool playertwo = false;
	bool showPlayerText = true;
	public Text playerText;

	public Image player1Sel;
	public Image player2Sel;

	public void SetImage(Sprite spr)
	{
		if (!playertwo)
		{
			player1Sel.sprite = spr;
		} else
		{
			player2Sel.sprite = spr;
		}
	}

	public void TadPole()
	{
		ClassButtonPress(PlayerClasses.TadPole);
	}

	public void Charger()
	{
		ClassButtonPress(PlayerClasses.Charger);
	}

	public void Beetle()
	{
		ClassButtonPress(PlayerClasses.Beetle);
	}

	public void Aura()
	{
		ClassButtonPress(PlayerClasses.Aura);
	}

	public void Lazer()
	{
		ClassButtonPress(PlayerClasses.Lazer);
	}

	public void TripleShot()
	{
		ClassButtonPress(PlayerClasses.TripleShot);
	}

	void ClassButtonPress(PlayerClasses playerClass)
	{
		if (!playertwo)
		{
			SelectionData.p1Class = playerClass;
			if (SelectionData.currentGameMode == GameModes.TowerDefense)
			{

			}
			playertwo = true;
            if (showPlayerText)
            {
				playerText.text = "Player 2";
            }
        } else
		{
			SelectionData.p2Class = playerClass;
			LoadLevel();
		}
	}
	void LoadLevel()
	{
        if (SelectionData.currentGameMode == GameModes.Brawl)
        {
            int Num = Random.Range(1, 33);
            SceneManager.LoadScene("1V" + Num);
        }
        else
        {
            SceneManager.LoadScene("Tower Defence");
        }
    }
	void Start(){
		SelectionData.p1Class = PlayerClasses.TadPole;
		SelectionData.p2Class = PlayerClasses.TadPole;
		if (SelectionData.currentGameMode == GameModes.TowerDefense)
		{
			playerText.text = "";
			player2Sel.enabled = false;
			showPlayerText = false;
		}
	}
}
