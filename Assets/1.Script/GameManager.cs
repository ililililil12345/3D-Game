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

        //���߿� ����� �� ����
        PlayerPrefs.SetInt("highestScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
