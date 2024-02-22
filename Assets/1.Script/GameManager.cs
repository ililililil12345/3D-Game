using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("highestScore"))
        {
            PlayerPrefs.SetInt("highestScore", 0);
        }
        if (!PlayerPrefs.HasKey("BGSTgl"))
        {
            PlayerPrefs.SetInt("BGSTgl", 1);
        }
        if (!PlayerPrefs.HasKey("CSTgl"))
        {
            PlayerPrefs.SetInt("CSTgl", 1);
        }

        //개발용 빌드시 꼭 삭제
        PlayerPrefs.SetInt("highestScore", 0);
        Screen.SetResolution(720 / 2, 1280 / 2, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
