using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject truck;

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
            return;
        }
        
        //이동
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0, 270, 0);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            deadDelayTimer = 2.5f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 360, 0);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
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
}
