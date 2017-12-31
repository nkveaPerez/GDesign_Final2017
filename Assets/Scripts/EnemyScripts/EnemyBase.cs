using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase
{

    public string enemyName;
    public int enemyHealth;
    public int enemyMaxHealth;
    public int enemyAP;
    public int enemyMaxAP;
    public int rollFactor;

    public string EnemyName
    {
        get { return enemyName; }
        set { enemyName = value; }
    }
    public int EnemyHealth
    {
        get { return enemyHealth; }
        set { enemyHealth = value; }
    }
    public int EnemyMaxHealth
    {
        get { return enemyMaxHealth; }
        set { enemyMaxHealth = value; }
    }
    public int EnemyAP
    {
        get { return enemyAP; }
        set { enemyAP = value; }
    }
    public int EnemyMaxAP
    {
        get { return enemyMaxAP; }
        set { enemyMaxAP = value; }
    }
    public int RollFactor
    {
        get { return rollFactor; }
        set { rollFactor = value; }
    }
}
