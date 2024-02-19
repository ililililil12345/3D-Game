using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class UI : MonoBehaviour
{
    [SerializeField] private TMP_Text myScoreTxt;


    // Start is called before the first frame update
    void Start()
    {
        GameData.gameState = GameData.GameState.Lobby;
        myScoreTxt.gameObject.SetActive(false);
        GameData.score = 0;


    }

    // Update is called once per frame
    void Update()
    {
        if (GameData.gameState == GameData.GameState.Game)
        {
            myScoreTxt.gameObject.SetActive(true);
        }
        if (GameData.gameState == GameData.GameState.Dead)
        {
            Invoke("OnDead", 4.5f);
        }
        myScoreTxt.text = $"{(int)GameData.score}";
    }
    public void StartGame()
    {
        GameData.gameState = GameData.GameState.Game;
    }
    public void OnDead()
    {
        SceneManager.LoadScene("Dead");
    }
}
