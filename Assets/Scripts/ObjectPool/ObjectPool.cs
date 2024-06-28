using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefabNowUsing;
    [Tooltip("max Pool size")]
    public int initialPoolSize = 10;

    private Dictionary<int, PoolableObject> objPool = new Dictionary<int, PoolableObject>();
    private int nextPoolableObj_Id = 0;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < initialPoolSize; i++)
        {
            CreateNewObject();
        }
    }

    private PoolableObject CreateNewObject()
    {
        GameObject targetObj = Instantiate(prefabNowUsing);
        PoolableObject targetPoolableObj = targetObj.AddComponent<PoolableObject>();
        targetPoolableObj.poolFromObj = this;
        targetObj.SetActive(true);
        objPool[nextPoolableObj_Id] = targetPoolableObj;
        nextPoolableObj_Id++;
        return targetPoolableObj;
    }

    public PoolableObject GetObjectInPool()
    {
        foreach(var itemValueInPool in objPool.Values)
        {
            if(!itemValueInPool.gameObject.activeInHierarchy)
            {
                itemValueInPool.gameObject.SetActive(true);
                return itemValueInPool;
            }
        }

        // pool empty
        return CreateNewObject();
    }   
    
    public void ReturnObject(PoolableObject objToReturn)
    {
        objToReturn.gameObject.SetActive(false);
    }
}
