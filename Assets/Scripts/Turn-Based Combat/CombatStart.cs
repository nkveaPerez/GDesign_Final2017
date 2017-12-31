using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatStart : MonoBehaviour
{

    public EnemyBase newEnemy = new EnemyBase();
    public GameInformation somePlayer = new GameInformation();

    public void PrepareBattle()
    {
        CreateNewEnemy();
        RollForFirst();
    }

    private void CreateNewEnemy()
    {
        newEnemy.EnemyName = "Copperhead";
        newEnemy.EnemyHealth = Random.Range(10, 15);
        newEnemy.EnemyAP = Random.Range(14, 18);
        newEnemy.RollFactor = Random.Range(1, 6);
        newEnemy.EnemyMaxHealth = newEnemy.EnemyHealth;
        newEnemy.EnemyMaxAP = newEnemy.EnemyAP;
    }

    private void RollForFirst()
    {
        if(GameInformation.RollFactor >= newEnemy.RollFactor)
        {
            TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleState.PLAYERCHOICE;
        }
        else
        {
            TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleState.ENEMYCHOICE;
        }
    }
}
