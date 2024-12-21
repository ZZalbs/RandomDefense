using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    [SerializeField]
    public List<TowerInfo> towerList = new List<TowerInfo>();
    // 현재는 public 에서 입력하는 방식. 나중에 scriptableObject에서 데이터 받는걸로 바꾸기
    public Canvas shopUI;
    List<TowerInfo> pickedTower = new List<TowerInfo>();

    public void ShowPickedTowerUI()
    {

    }

    public List<TowerInfo> PickThreeTower(int curLevel)
    {
        pickedTower.Clear();
        for(int i=0;i<3;i++)
            pickedTower.Add(PickRandomTower(curLevel));
        return pickedTower;
    }

    TowerInfo PickRandomTower(int curLevel)
    {
        return towerList[getRandomNaturalNum(curLevel)];
    }
    
    int getRandomNaturalNum(int max)
    {
        return Random.Range(0, max)+1;
    }
}
