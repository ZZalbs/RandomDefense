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
        int weight = 0;
        int randomResult = getRandomNaturalNum(curLevel);
        for(int i=0;i<towerList.Count;i++)
        {
            weight++;
            if(randomResult<=weight)
            {
                TowerInfo selectTower = towerList[i];
                return selectTower;
            }
        }
        return null;
    }

    int getRandomNaturalNum(int max)
    {
        return Random.Range(0, max)+1;
    }
}
