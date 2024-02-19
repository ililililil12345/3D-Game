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
            spawnTimer = Random.Range(1, 4);
            Car c = Instantiate(car[Random.Range(0, car.Count)], transform);
            c.transform.parent = parent;
        }
    }
}
