using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerClasses
{
    TadPole = 0,
    Charger,
    Beetle,
    Aura,
    Lazer,
    TripleShot
}

public enum GameModes
{
    Brawl = 0,
    TowerDefense
}

public static class SelectionData
{
    public static GameModes currentGameMode = GameModes.Brawl;
    public static PlayerClasses p1Class = PlayerClasses.TadPole;
    public static PlayerClasses p2Class = PlayerClasses.TadPole;
}
