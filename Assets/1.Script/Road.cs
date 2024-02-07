using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private Player p;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (p.transform.position.x <= transform.position.x - 30)
        {
            transform.position = new Vector3(transform.position.x - 120, 0, 0);
        }
    }
}
