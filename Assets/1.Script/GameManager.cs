using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    public enum GameState
    {
        Lobby,
        Game,
        Dead
    }
    public static GameState gameState;
}
