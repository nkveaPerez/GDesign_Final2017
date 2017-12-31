using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCalculations
{

    private int abilityPower;
    private float totalAbilityPowerDamage;
    private int totalUsedAbilityDamage;

    public void CalculatePlayerAbilityDamage(BaseAbility usedAbility)
    {
        //Debug.Log("Used Ability: " + usedAbility.AbilityName);

        totalUsedAbilityDamage = (int)CalculateAbilityDamage(usedAbility);
        TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyHealth -= totalUsedAbilityDamage;
        TurnBasedCombatStateMachine.hasPlayerCompletedTurn = true;

        BattleGUI.logLine3 = BattleGUI.logLine2;
        BattleGUI.logLine2 = BattleGUI.logLine1;
        BattleGUI.logLine1 = "You used " + usedAbility.AbilityName + " dealing " + totalUsedAbilityDamage + " damage to the enemy.";
        //TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleState.ENEMYCHOICE;
        //Debug.Log(totalUsedAbilityDamage);

        //nts flesh out stats later, ie move damage + crit + status mods
        //use ability
        //calc damage
    }

    private float CalculateAbilityDamage(BaseAbility usedAbility)
    {
        abilityPower = usedAbility.AbilityPower;
        totalAbilityPowerDamage = abilityPower + Random.Range(-1,1);
        return totalAbilityPowerDamage;
    }

    public void CalculateEnemyAbilityDamage(BaseAbility usedAbility)
    {
        Debug.Log("Used Ability: " + usedAbility.AbilityName);

        totalUsedAbilityDamage = (int)CalculateAbilityDamage(usedAbility);
        GameInformation.PlayerHealth -= totalUsedAbilityDamage;

        TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyAP -= usedAbility.AbilityCost;

        BattleGUI.logLine3 = BattleGUI.logLine2;
        BattleGUI.logLine2 = BattleGUI.logLine1;
        BattleGUI.logLine1 = "The enemy used " + usedAbility.AbilityName + " dealing " + totalUsedAbilityDamage + " damage to you.";

        TurnBasedCombatStateMachine.hasEnemyCompletedTurn = true;
        //TurnBasedCombatStateMachine.hasEnemyCompletedTurn = true;
        //TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleState.PLAYERCHOICE;
        //Debug.Log(totalUsedAbilityDamage);

        //nts flesh out stats later, ie move damage + crit + status mods
        //use ability
        //calc damage
    }
}
