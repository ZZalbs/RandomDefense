using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField]
    public List<TowerInfo> towerList = new List<TowerInfo>();
    // 현재는 public 에서 입력하는 방식. 나중에 scriptableObject에서 데이터 받는걸로 바꾸기

    TowerInfo PickRandomTower(int curLevel)
    {
        return towerList[getRandomNaturalNum(curLevel)];
        
    }

    int getRandomNaturalNum(int max)
    {
        return Random.Range(0, max)+1;
    }
}
