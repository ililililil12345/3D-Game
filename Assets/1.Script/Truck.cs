using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{
    [SerializeField] private Transform cars;
    private void Start()
    {
        transform.parent = cars.parent;
    }
}
