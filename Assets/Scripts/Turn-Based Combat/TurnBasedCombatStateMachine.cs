using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurnBasedCombatStateMachine : MonoBehaviour
{
    public static CombatStart combatStartScript = new CombatStart();
    private BattleCalculations battleCalcScript = new BattleCalculations();
    private BattleStateEnemyChoice battleStateEnemyChoiceScript = new BattleStateEnemyChoice();
    private BattleStateEndTurn battleStateEndTurnScript = new BattleStateEndTurn();

    public static BaseAbility playerUsedAbility;
    public static BaseAbility enemyUsedAbility;
    public static int totalTurnCount;
    public static bool hasPlayerCompletedTurn;
    public static bool hasEnemyCompletedTurn;
    public static BattleState currentUser; //player or enemy

	public enum BattleState
    {
        START,
        PLAYERCHOICE,
        RESOLVEPLAYER,
        ENEMYCHOICE,
        ENDTURN,
        LOSE,
        WIN
    }

    public static BattleState currentState;

	void Start ()
    {
        //playerName = GameInformation.PlayerName;
        currentState = BattleState.START;
        totalTurnCount = 1;
	}
	
	
	void Update ()
    {
        Debug.Log(currentState);



		switch(currentState)
        {
            case BattleState.START:
                GameInformation.Battling = true;
                GameInformation.HasBeenCheckedSinceChange = false;
                GameInformation.AllowedToMove = false;
                BattleGUI.logLine1 = ""; BattleGUI.logLine2 = ""; BattleGUI.logLine3 = "";
                combatStartScript.PrepareBattle();
                break;
            case BattleState.PLAYERCHOICE: //obvious
                currentUser = BattleState.PLAYERCHOICE;
                break;
            case BattleState.RESOLVEPLAYER:
                if (currentUser == BattleState.PLAYERCHOICE)
                {
                    battleCalcScript.CalculatePlayerAbilityDamage(playerUsedAbility);
                }
                else if(currentUser == BattleState.ENEMYCHOICE)
                {
                    battleCalcScript.CalculateEnemyAbilityDamage(enemyUsedAbility);
                }
                CheckWhoGoesNext();
                break;
            case BattleState.ENEMYCHOICE:
                //ai code lmao
                currentUser = BattleState.ENEMYCHOICE;
                battleStateEnemyChoiceScript.EnemyTurnRoutine();
                //hasEnemyCompletedTurn = true;
                currentState = BattleState.RESOLVEPLAYER;
                
                //CheckWhoGoesNext();
                break;
            case BattleState.ENDTURN:
                totalTurnCount += 1;
                //hasPlayerCompletedTurn = false;
                //hasEnemyCompletedTurn = false;
                battleStateEndTurnScript.TurnResolution();
                break;
            case BattleState.LOSE:
                //GameInformation.Bodied = true;
                SceneManager.LoadScene("Scenes/GameOver");
                break;
            case BattleState.WIN:
                //SceneManager.LoadScene("Scenes/Start");
                SceneManager.UnloadSceneAsync("Scenes/ImprovedBattleScene");
                GameInformation.Battling = false;
                GameInformation.HasBeenCheckedSinceChange = false;
                GameInformation.AllowedToMove = true;
                break;
        }
	}
    
    void OnGUI()
    {
        /*if(GUILayout.Button("NEXT STATE"))
        {
            switch(currentState)
            {
                case BattleState.START:
                    currentState = BattleState.PLAYERCHOICE;
                    break;
                case BattleState.PLAYERCHOICE:
                    currentState = BattleState.RESOLVEPLAYER;
                    break;
                case BattleState.RESOLVEPLAYER:
                    currentState = BattleState.ENEMYCHOICE;
                    break;
                case BattleState.ENEMYCHOICE:
                    currentState = BattleState.ENDTURN;
                    break;
                case BattleState.ENDTURN:
                    currentState = BattleState.LOSE;
                    break;
                case BattleState.LOSE:
                    currentState = BattleState.WIN;
                    break;
                case BattleState.WIN:
                    currentState = BattleState.PLAYERCHOICE;
                    break;
            }
        }*/
    }

    private void CheckWhoGoesNext()
    {
        if(hasPlayerCompletedTurn && !hasEnemyCompletedTurn)
        {
            currentState = BattleState.ENEMYCHOICE;
        }

        if(!hasPlayerCompletedTurn && hasEnemyCompletedTurn)
        {
            currentState = BattleState.PLAYERCHOICE;
        }

        if(hasPlayerCompletedTurn && hasEnemyCompletedTurn)
        {
            currentState = BattleState.ENDTURN;
        }
    }
}
