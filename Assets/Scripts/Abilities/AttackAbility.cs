
[System.Serializable]

public class AttackAbility : BaseAbility
{ 
    public AttackAbility()
    {
        AbilityName = "Basic Attack";
        AbilityDescription = "A normal attack.";
        AbilityID = 1;
        AbilityPower = 4;
        AbilityCost = 0;
    }
}
