using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAbilityChoice
{

    private int totalPlayerHealth;
    private int playerHealthPercentage;
    private BaseAbility chosenAbility;


    public BaseAbility ChooseEnemyAbility()
    {
        totalPlayerHealth = GameInformation.PlayerMaxHealth;
        if (GameInformation.PlayerHealth != 0) playerHealthPercentage = (int)(totalPlayerHealth / GameInformation.PlayerHealth) * 100;
        else playerHealthPercentage = 0;

        if(playerHealthPercentage >= 75)
        {
            //do this
            if (Random.Range(1, 6) > 3 && TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyAP >= 7)
            {
                return chosenAbility = new Bite();
            }
            else
            {
                return chosenAbility = new AttackAbility();
            }
        }
        else if(playerHealthPercentage < 75 && playerHealthPercentage >= 25 && TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyAP >= 7)
        {
            if (Random.Range(1, 6) > 4)
            {
                return chosenAbility = new Bite();
            }
            else
            {
                return chosenAbility = new AttackAbility();
            }
        }
        else
        {
            if (Random.Range(1, 6) > 5 && TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyAP >= 7)
            {
                return chosenAbility = new Bite();
            }
            else
            {
                return chosenAbility = new AttackAbility();
            }
        }
    }

    /*private BaseAbility ChooseAbilityAtSeventyFivePercent()
    {

        //may replace contents of health rangees within ChooseEnemyAbility() function

    }*/
}
