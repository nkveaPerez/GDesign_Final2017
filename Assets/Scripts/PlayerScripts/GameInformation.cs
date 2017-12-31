using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour //information to span scenes
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    //public static List<BaseAbility> playersAbilities;

    public static bool allowedToMove = true;
    public static bool battling = false;
    public static bool hasBeenCheckedSinceChange = false;

    public static bool isInShop = false;

    public static string playerName = "Parker";
    public static int playerHealth = 40;
    public static int playerAP = 20;
    public static int rollFactor = 4;

    public static int playerMaxHealth = 40;
    public static int playerMaxAP = 20;

    /*public static string PlayerName { get; set; }
    public static int PlayerMaxHealth { get; set; }
    public static int PlayerHealth { get; set; }
    public static int PlayerMaxAP { get; set; }
    public static int PlayerAP { get; set; }
    public static int RollFactor { get; set; }*/

    public static bool IsInShop
    {
        get { return isInShop; }
        set { isInShop = value; }
    }

    public static bool AllowedToMove
    {
        get { return allowedToMove; }
        set { allowedToMove = value; }
    }
    public static bool Battling
    {
        get { return battling; }
        set { battling = value; }
    }
    public static bool HasBeenCheckedSinceChange
    {
        get { return hasBeenCheckedSinceChange; }
        set { hasBeenCheckedSinceChange = value; }
    }

    public static string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }
    public static int PlayerHealth
    {
        get { return playerHealth; }
        set { playerHealth = value; }
    }
    public static int PlayerAP
    {
        get { return playerAP; }
        set { playerAP = value; }
    }
    public static int RollFactor
    {
        get { return rollFactor; }
        set { rollFactor = value; }
    }

    public static int PlayerMaxHealth
    {
        get { return playerMaxHealth; }
        set { playerMaxHealth = value; }
    }
    public static int PlayerMaxAP
    {
        get { return playerMaxAP; }
        set { playerMaxAP = value; }
    }


    public static BaseAbility playerMoveOne = new AttackAbility();
    public static BaseAbility playerMoveTwo = new Shimmer();
}
