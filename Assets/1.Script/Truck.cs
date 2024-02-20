using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{
    [SerializeField] private Transform cars;
    [SerializeField] private SoundPlayer collisionalSound;
    private void Start()
    {
        transform.parent = cars.parent;
        if (PlayerPrefs.GetInt("CSTgl") == 1)
        {
            Invoke("OnSound", 2.3f);
        }
    }
    void OnSound()
    {
        collisionalSound.gameObject.SetActive(true);
    }
}
