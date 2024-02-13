using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject deadTitle;
    [SerializeField] private GameObject lobbyTitle;

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
        else
        {
            deadTitle.SetActive(false);
        }
        if (GameManager.gameState == GameManager.GameState.Lobby)
        {
            lobbyTitle.SetActive(true);
        }
        else
        {
            lobbyTitle.SetActive(false);
        }
    }
    public void StartGame()
    {
        GameManager.gameState = GameManager.GameState.Game;
    }
    public void OnDead()
    {
        deadTitle.SetActive(true);
    }
    public void OnLobby()
    {
        GameManager.gameState = GameManager.GameState.Lobby;
    }
}
