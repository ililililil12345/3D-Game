using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    [SerializeField] private GameObject truck;
    [SerializeField] private Image deadBody;
    [SerializeField] private Animator[] playerAM;
    [SerializeField] private SoundPlayer collisionalSound;

    [SerializeField] private int speed;
    [SerializeField] private float deadDelayTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameData.gameState != GameData.GameState.Game)
        {
            if (GameData.gameState == GameData.GameState.Dead)
            {
                playerAM[0].enabled = false;
            }
            return;
        }
        
        //이동
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0, 270, 0);
            playerAM[1].enabled = true;
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            deadDelayTimer = 2.5f;
            //점수
            GameData.score += 0.0025f;
            if (GameData.score >= GameData.highestScore)
            {
                PlayerPrefs.SetInt("highestScore", (int)GameData.score);
            }
        }
        else if (Input.GetKey(KeyCode.A) && transform.position.z >= -9.5f)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            playerAM[1].enabled = true;
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.D) && transform.position.z <= 9.5f)
        {
            transform.rotation = Quaternion.Euler(0, 360, 0);
            playerAM[1].enabled = true;
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || GameData.gameState != GameData.GameState.Game)
        {
            playerAM[1].enabled = false;
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }

        //제한시간
        deadDelayTimer -= Time.deltaTime;
        if (deadDelayTimer <= 0)
        {
            //gameObject.SetActive(false);
            GameData.gameState = GameData.GameState.Dead;
            truck.SetActive(true);
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Car>())
        {
            GameData.gameState = GameData.GameState.Dead;
            if (PlayerPrefs.GetInt("CSTgl") == 1)
            {
                collisionalSound.gameObject.SetActive(true);
            }
            deadBody.gameObject.SetActive(true);
            deadBody.transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
            gameObject.SetActive(false);
        }
    }
}
