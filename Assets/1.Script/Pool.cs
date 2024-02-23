using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : Singleton<Pool>
{
    public List<GameObject> coinPool = new List<GameObject>();
    public List<GameObject> carPool = new List<GameObject>();

    public void InPool(GameObject obj)
    {
        if (obj.GetComponent<Coin>())
        {
            coinPool.Add(obj);
        }
        else if (obj.GetComponent<Car>())
        {
            carPool.Add(obj);
        }
        obj.transform.parent = transform.parent;
        obj.SetActive(false);
    }
    
}
