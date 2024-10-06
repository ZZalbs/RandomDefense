using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class ObjectPoolManager: MonoBehaviour
{
	//ΩÃ±€≈Ê
	private static ObjectPoolManager privateInstance;
	public static ObjectPoolManager publicInstance()
	{
		if (privateInstance == null)
		{
			privateInstance = new ObjectPoolManager();
		}
		return privateInstance;
	}

	static List<GameObject> prefabList;
    [Tooltip("max Pool size per object")]
    [HideInInspector]
    public int initialPoolSize = 10;

    [Title("Dictionary")]
    [ShowInInspector]
    private Dictionary<GameObject,Dictionary<int,PoolableObject>> objPools = new Dictionary<GameObject, Dictionary<int, PoolableObject>>();
    private int nextPoolableObj_Id = 0;

    public static void ListUpdate(GameObject obj)
    {
        prefabList.Add(obj);
    }

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

	//https://github.com/UnityPatterns/ObjectPool/blob/master/Assets/ObjectPool/Scripts/ObjectPool.cs
    //¬¸∞Ìø‰
	private static PoolableObject CreateNewObject(GameObject obj)
    {
        GameObject targetObj = Instantiate(obj);
        PoolableObject targetPoolableObj = targetObj.AddComponent<PoolableObject>();
        targetPoolableObj.poolManager = privateInstance;
        targetObj.SetActive(false);
        privateInstance.objPools[obj][privateInstance.nextPoolableObj_Id] = targetPoolableObj;
		privateInstance.nextPoolableObj_Id++;
        return targetPoolableObj;
    }

    private void ResetID()
    {
        nextPoolableObj_Id = 0;
    }

    public static PoolableObject SpawnObject(GameObject obj)
    {
        if(!privateInstance.objPools.ContainsKey(obj))
        {
            Debug.LogError(obj.name+" not in pool");
            return null;
        }
        foreach(var itemValueInPool in privateInstance.objPools[obj].Values)
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
