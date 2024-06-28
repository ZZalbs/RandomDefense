using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolableObject : MonoBehaviour
{
    public ObjectPool poolFromObj { get; set; }

    public void ReturnToPool()
    {
        gameObject.SetActive(false);
        poolFromObj.ReturnObject(this);
    }
}
