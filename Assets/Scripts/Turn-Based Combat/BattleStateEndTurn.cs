using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateEndTurn
{

    public void TurnResolution()
    {
        if (GameInformation.PlayerHealth <= 0)
        {
            TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleState.LOSE;
        }
        else if (TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyHealth <= 0)
        {
            TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleState.WIN;
        }
        else
        {
            if (TurnBasedCombatStateMachine.hasPlayerCompletedTurn && TurnBasedCombatStateMachine.hasEnemyCompletedTurn)
            {
                TurnBasedCombatStateMachine.hasPlayerCompletedTurn = false;
                TurnBasedCombatStateMachine.hasEnemyCompletedTurn = false;
                TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleState.PLAYERCHOICE;
            }
        }
    }
}
