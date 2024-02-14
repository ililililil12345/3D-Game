using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject truck;
    [SerializeField] private Animator[] playerAM;

    [SerializeField] private int speed;
    [SerializeField] private float deadDelayTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameState != GameManager.GameState.Game)
        {
            if (GameManager.gameState == GameManager.GameState.Dead)
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
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || GameManager.gameState != GameManager.GameState.Game)
        {
            playerAM[1].enabled = false;
        }

        //제한시간
        deadDelayTimer -= Time.deltaTime;
        if (deadDelayTimer <= 0)
        {
            //gameObject.SetActive(false);
            GameManager.gameState = GameManager.GameState.Dead;
            truck.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Car>())
        {
            transform.localScale = new Vector3(2, 0.45f, 1);
            GameManager.gameState = GameManager.GameState.Dead;
        }
    }
}
