using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInformation : MonoBehaviour {

    public string playerName = "Parker";

    public int playerHealth;
    public int playerAP;
    public int rollFactor;

    public int PlayerHealth
    {
        get{ return playerHealth; }
        set{ playerHealth = value; }
    }
    public int PlayerAP
    {
        get { return playerAP; }
        set { playerAP = value; }
    }
    public string PlayerName()
    {
        return playerName;
    }
    public int RollFactor
    {
        get { return rollFactor; }
        set { rollFactor = value; }
    }
}
