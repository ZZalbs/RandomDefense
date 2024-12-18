using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerInfo:MonoBehaviour
{
    [SerializeField]
    private string towerName;
    public string pub_towerName { get { return towerName; } }

    [SerializeField]
    private string discription;
    public string pub_discription { get { return discription; } }

    [SerializeField]
    private int appearLevel;
    public int pub_appearLevel { get { return appearLevel; } }

    [SerializeField]
    private int dmg;
    public int pub_dmg { get { return dmg; } }

    [SerializeField]
    private int atkDelay;
    public int pub_atkDelay { get { return atkDelay; } }

    [SerializeField]
    private int range;
    public int pub_range { get { return range; } }
}
