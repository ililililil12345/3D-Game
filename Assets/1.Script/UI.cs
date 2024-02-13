using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        GameManager.gameState = GameManager.GameState.Lobby;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        GameManager.gameState = GameManager.GameState.Game;
    }
}
