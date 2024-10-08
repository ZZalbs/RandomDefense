using Sirenix.OdinInspector;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditor;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{

    public Pool_Info[] pool_info;

    Dictionary<GameObject,List<GameObject>> pool_list = new Dictionary<GameObject, List<GameObject>>();
    
    void InitPool()
    {
        if (pool_info != null && pool_info.Length > 0)
            for (int i = 0; i < pool_info.Length; i++)
                CreatePool(pool_info[i].prefab, pool_info[i].size);
    }
    
    void CreatePool<T>(T prefab,int poolSize) where T:Component
    {
        CreatePool(prefab.gameObject,poolSize);
    }

    void CreatePool(GameObject obj,int poolSize)
    {
        if(obj!=null && pool_list.ContainsKey(obj))
        {
            var objList = new List<GameObject>();
            pool_list.Add(obj, objList);
            for(int i=0;i<poolSize; i++)
            {
                GameObject newObject = Object.Instantiate(obj);
                objList.Add(newObject);
                newObject.SetActive(false);
            }
        }
    }

}
