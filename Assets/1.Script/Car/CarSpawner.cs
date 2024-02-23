using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private List<Car> car;
    [SerializeField] private Transform parent;

    private float spawnTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            if (Pool.Instance.coinPool.Count == 0)
            {
                spawnTimer = Random.Range(1, 5);
                Car c = Instantiate(car[Random.Range(0, car.Count)], transform);
                c.transform.parent = parent;
            }
            else
            {
                spawnTimer = Random.Range(1, 5);
                GameObject c = Pool.Instance.carPool[Pool.Instance.carPool.Count - 1];
                Pool.Instance.carPool.Remove(c);
                c.transform.parent = parent;
                c.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                c.SetActive(true);
            }
        }
    }
}
