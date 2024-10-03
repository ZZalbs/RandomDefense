using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolableObject : MonoBehaviour
{
    public ObjectPoolManager poolManager { get; set; }

    public void ReturnToPool()
    {
        gameObject.SetActive(false);
        poolManager.ReturnObject(this);
    }
}
