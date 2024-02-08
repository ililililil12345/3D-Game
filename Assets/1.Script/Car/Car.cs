using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Car : MonoBehaviour
{
    [SerializeField] private Vector3 dic;
    struct Data
    {
        public float speed;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dic * Time.deltaTime * 10f);
        if (transform.position.z >= 25 || transform.position.z <= -55)
        {
            Destroy(gameObject);
        }
    }
}
