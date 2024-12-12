using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tower Data", menuName = "Scriptable Object/Tower Data")]
public class TowerData : ScriptableObject
{
    private string towerName;
    public string pub_towerName { get { return towerName; } }

    private string discription;
    public string pub_discription { get { return discription; } }

    private int appearLevel;
    public int pub_appearLevel { get { return appearLevel; } }

    private int dmg;
    public int pub_dmg { get { return dmg; } }

    private int atkDelay;
    public int pub_atkDelay { get { return atkDelay; } }

    private int range;
    public int pub_range { get { return range; } }
}
