using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class DeadUI : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreTxt;
    [SerializeField] private TMP_Text highScoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        scoreTxt.text = $"{(int)GameManager.score}";
        highScoreTxt.text = $"최고점수 : {GameManager.highestScore}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnLobby()
    {
        SceneManager.LoadScene("Game");
        GameManager.gameState = GameManager.GameState.Lobby;
    }
}
