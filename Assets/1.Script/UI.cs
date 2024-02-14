using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        if (GameManager.gameState == GameManager.GameState.Dead)
        {
            Invoke("OnDead", 4.5f);
        }
    }
    public void StartGame()
    {
        GameManager.gameState = GameManager.GameState.Game;
    }
    public void OnDead()
    {
        SceneManager.LoadScene("Dead");
    }
    public void OnLobby()
    {
        SceneManager.LoadScene("Game");
        GameManager.gameState = GameManager.GameState.Lobby;
    }
}
