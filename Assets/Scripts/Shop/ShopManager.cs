using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField]
    public List<TowerInfo> towerList = new List<TowerInfo>();
    // ����� public ���� �Է��ϴ� ���. ���߿� scriptableObject���� ������ �޴°ɷ� �ٲٱ�

    TowerInfo PickRandomTower(int curLevel)
    {
        return towerList[getRandomNaturalNum(curLevel)];
        
    }

    int getRandomNaturalNum(int max)
    {
        return Random.Range(0, max)+1;
    }
}
