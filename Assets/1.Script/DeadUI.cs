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
    [SerializeField] private TMP_Text loading;
    // Start is called before the first frame update
    void Start()
    {
        scoreTxt.text = $"{(int)GameData.score}";
        if (PlayerPrefs.HasKey("highestScore"))
        {
            highScoreTxt.text = $"�ְ����� : {PlayerPrefs.GetInt("highestScore")}";
        }
        else
        {
            Debug.LogError("���̺� ���� ����");
        }
        loading.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnLobby()
    {
        loading.gameObject.SetActive(true);
        SceneManager.LoadScene("Game");
        GameData.gameState = GameData.GameState.Lobby;
    }
}
