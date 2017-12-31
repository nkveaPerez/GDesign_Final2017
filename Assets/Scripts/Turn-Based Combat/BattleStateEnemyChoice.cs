using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateEnemyChoice
{

    private EnemyAbilityChoice enemyAbilityChoiceScript = new EnemyAbilityChoice();
    private BaseAbility enemyChoiceAbility;

    public void EnemyTurnRoutine()
    {
        //choose ability
        TurnBasedCombatStateMachine.enemyUsedAbility = enemyAbilityChoiceScript.ChooseEnemyAbility();
        //Debug.Log("Enemy Choice: " + TurnBasedCombatStateMachine.enemyUsedAbility.AbilityName);
        //calculate damage
        TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleState.RESOLVEPLAYER;
        //end turn
    }


}
