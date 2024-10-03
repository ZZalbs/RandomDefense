using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolManager: MonoBehaviour
{
    public List<GameObject> prefabList;
    [Tooltip("max Pool size per object")]
    public int initialPoolSize = 10;

    private Dictionary<GameObject,Dictionary<int,PoolableObject>> objPools = new Dictionary<GameObject, Dictionary<int, PoolableObject>>();

    private int nextPoolableObj_Id = 0;

    public void InitPool()
    {
        foreach (var obj in prefabList)
        {
            objPools[obj] = new Dictionary<int, PoolableObject>();
            ResetID();
            for (int i = 0; i < initialPoolSize; i++)
            {
                CreateNewObject(obj);
            }
        }
    }

    private PoolableObject CreateNewObject(GameObject obj)
    {
        GameObject targetObj = Instantiate(obj);
        PoolableObject targetPoolableObj = targetObj.AddComponent<PoolableObject>();
        targetPoolableObj.poolManager = this;
        targetObj.SetActive(false);
        objPools[obj][nextPoolableObj_Id] = targetPoolableObj;
        nextPoolableObj_Id++;
        return targetPoolableObj;
    }

    private void ResetID()
    {
        nextPoolableObj_Id = 0;
    }

    public PoolableObject GetObjectInPool(GameObject obj)
    {
        if(!objPools.ContainsKey(obj))
        {
            Debug.LogError(obj.name+" not in pool");
            return null;
        }
        foreach(var itemValueInPool in objPools[obj].Values)
        {
            if(!itemValueInPool.gameObject.activeInHierarchy)
            {
                itemValueInPool.gameObject.SetActive(true);
                return itemValueInPool;
            }
        }
        // pool empty
        return CreateNewObject(obj);
    }
    
    public void ReturnObject(PoolableObject objToReturn)
    {
        objToReturn.gameObject.SetActive(false);
    }
}
