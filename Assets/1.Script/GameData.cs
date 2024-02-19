using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameData
{
    public enum GameState
    {
        Lobby,
        Game,
        Dead
    }

    public static GameState gameState;
    public static float score;
    public static int highestScore = 0;

}
