using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    //[SerializeField] private Vector3 dic;

    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z >= 70 || transform.position.z <= -80)
        {
            //Destroy(gameObject);
            Pool.Instance.InPool(gameObject);
        }
    }
}
