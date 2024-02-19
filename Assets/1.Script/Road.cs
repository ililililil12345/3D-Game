using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private Player p;
    [SerializeField] private List<GameObject> buildings;
    [SerializeField] private bool buildingRoad;
    GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        if (buildingRoad)
        {
            b = Instantiate(buildings[Random.Range(0, buildings.Count)], transform.position, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (p.transform.position.x <= transform.position.x - 30)
        {
            transform.position = new Vector3(transform.position.x - 120, 0, 0);
            if (buildingRoad)
            {
                if (b != null)
                {
                    Destroy(b);
                }
                b = Instantiate(buildings[Random.Range(0, buildings.Count)], transform.position, Quaternion.identity);
            }
        }
    }
}
