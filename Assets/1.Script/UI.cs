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
        GameManager.gameState = GameManager.GameState.Lobby;
        myScoreTxt.gameObject.SetActive(false);
        GameManager.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameState == GameManager.GameState.Game)
        {
            myScoreTxt.gameObject.SetActive(true);
        }
        if (GameManager.gameState == GameManager.GameState.Dead)
        {
            Invoke("OnDead", 4.5f);
        }
        myScoreTxt.text = $"{(int)GameManager.score}";
    }
    public void StartGame()
    {
        GameManager.gameState = GameManager.GameState.Game;
    }
    public void OnDead()
    {
        SceneManager.LoadScene("Dead");
    }
}
