using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleGUI : MonoBehaviour {

    private HealthDisplayScript newHealthDisplayScript = new HealthDisplayScript();

    private string abilDesc;

    private int selection = 0;
    private bool selectionMade = true;
    private bool selectionPos = false;

    private int abilSelection = 0;
    private bool abilSelectionMade = true;
    private bool abilSelectionPos = true;

    private bool mainMenuIsActive = true;
    private bool abilMenuIsActive = false;

    private Vector3 desDeg = new Vector3(0, 0, 0);
    private Vector3 curDeg = new Vector3(0, 0, 0);

    private string playerName;
    private int playerHealth;
    private int playerAP;

    public static string logLine1 = "", logLine2 = "", logLine3 = "";

    private GameObject battleCanvas;

    private GameObject enemyInfoContainer;
    private GameObject enemyHealthBar;
    private GameObject enemyHealthValue;

    private GameObject enemyAPBar;
    private GameObject enemyAPValue;

    private GameObject enemyPortrait;
    private GameObject enemyNameplate;

    private Image enemyHealthBarImage;
    private Image enemyAPBarImage;

    private Text enemyHealthText;
    private Text enemyAPText;

    private Text enemyNameplateValue;
    private GameObject enemyPortraitImage;

    private Vector3 enemyPortOriginalPos;

    private GameObject battleLogContainer;
    private GameObject battleLog;
    private GameObject logText;

    private GameObject selectionContainer;
    private GameObject leftSelection;
    private GameObject rightSelection;

    private GameObject attack;
    private GameObject ability;
    private GameObject guard;
    private GameObject item;

    private GameObject lensGearContainer;

    private GameObject bg;
    private Image bgImage;

    private float desCol = 0;

    private Image leftHighlight;
    private Image rightHighlight;

    private Text logTextText;

    private bool shakeActive = false;
    private float shakeTime;

    private string logLine5 = "", logLine6 = "";

    private float time;
    private float refTime;
    //kys
    void Start ()
    {
        newHealthDisplayScript.HealthInit();

        //Transform playerHealthTextChild = transform.Find("PlayerInfoContainer").Find("HealthBar").Find("PlayerHealthValue");
        //Transform playerHealthTextChild = battleCanvas.transform.Find("PlayerHealthValue");

        battleCanvas = GameObject.Find("BattleCanvas");

        selectionContainer = battleCanvas.transform.Find("SelectionContainer").gameObject;
        leftSelection = selectionContainer.transform.Find("LeftSelection").gameObject;
        rightSelection = selectionContainer.transform.Find("RightSelection").gameObject;

        leftHighlight = leftSelection.GetComponent<Image>();
        rightHighlight = rightSelection.GetComponent<Image>();

        bg = battleCanvas.transform.Find("bg").gameObject;
        bgImage = bg.GetComponent<Image>();

        enemyInfoContainer = battleCanvas.transform.Find("EnemyInfoContainer").gameObject;
        enemyHealthBar = enemyInfoContainer.transform.Find("EnemyHealthBar").gameObject;
        enemyHealthValue = enemyHealthBar.transform.Find("EnemyHealthValue").gameObject;

        enemyAPBar = enemyInfoContainer.transform.Find("EnemyAPBar").gameObject;
        enemyAPValue = enemyAPBar.transform.Find("EnemyAPValue").gameObject;

        enemyPortrait = enemyInfoContainer.transform.Find("Portrait").gameObject;
        enemyNameplate = enemyPortrait.transform.Find("EnemyName").gameObject;

        enemyNameplateValue = enemyNameplate.GetComponent<Text>();

        enemyHealthText = enemyHealthValue.GetComponent<Text>();
        enemyAPText = enemyAPValue.GetComponent<Text>();

        enemyHealthBarImage = enemyHealthBar.GetComponent<Image>();
        enemyAPBarImage = enemyAPBar.GetComponent<Image>();

        enemyPortraitImage = enemyPortrait.transform.Find("PortraitImage").gameObject;
        enemyPortOriginalPos = enemyPortraitImage.transform.position;

        battleLogContainer = battleCanvas.transform.Find("BattleLogContainer").gameObject;
        battleLog = battleLogContainer.transform.Find("BattleLog").gameObject;
        logText = battleLog.transform.Find("LogText").gameObject;

        attack = battleLog.transform.Find("AttackOptionText").gameObject;
        ability = battleLog.transform.Find("AbilityOptionText").gameObject;
        guard = battleLog.transform.Find("GuardOptionText").gameObject;
        item = battleLog.transform.Find("ItemOptionText").gameObject;

        lensGearContainer = battleLog.transform.Find("LensGearContainer").gameObject;

        logTextText = logText.GetComponent<Text>();
	}

    void Update()
    {
        time += Time.deltaTime;

        if(GameInformation.Battling && bgImage.color.a < 0.66)
        {
            desCol += 0.5f * Time.deltaTime;
            bgImage.color = new Color(bgImage.color.r, bgImage.color.g, bgImage.color.b, desCol);
        }

        newHealthDisplayScript.HealthUpdate();

        //Debug.Log(TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyAP);

        enemyHealthText.text = "HP: " + TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyHealth.ToString();
        enemyAPText.text = "AP: " + TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyAP.ToString();

        enemyNameplateValue.text = TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyName.ToString();

        if (TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyHealth > 0) enemyHealthBarImage.fillAmount = (float)TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyHealth
                 / (float)TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyMaxHealth;
        else if (TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyHealth == 0) enemyHealthBarImage.fillAmount = 0;
        if (TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyAP > 0) enemyAPBarImage.fillAmount = (float)TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyAP
                / (float)TurnBasedCombatStateMachine.combatStartScript.newEnemy.EnemyMaxAP;

        if (mainMenuIsActive)
        {
            logLine5 = "";

            switch (selection)
            {
                case 0:

                    abilDesc = GameInformation.playerMoveOne.AbilityDescription;
                    attack.SetActive(true);
                    ability.SetActive(false);
                    guard.SetActive(false);
                    item.SetActive(false);
                    break;

                case 1:

                    abilDesc = "Choose an ability.";
                    attack.SetActive(false);
                    ability.SetActive(true);
                    guard.SetActive(false);
                    item.SetActive(false);
                    break;

                case 2:

                    abilDesc = "This feature has not yet been implemented.";
                    attack.SetActive(false);
                    ability.SetActive(false);
                    guard.SetActive(true);
                    item.SetActive(false);
                    break;

                case 3:

                    abilDesc = "This feature has not yet been implemented.";
                    attack.SetActive(false);
                    ability.SetActive(false);
                    guard.SetActive(false);
                    item.SetActive(true);
                    break;
            }

        }

        logTextText.text = (logLine1 + "\n\n" + logLine2 + "\n\n" + logLine3 + "\n\n\n\n" + abilDesc + "\n\n" + logLine5);

        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        
        if (mainMenuIsActive)
        {
            if (movement_vector.y > 0.25 || movement_vector.y < -0.25 && !selectionMade) selectionPos = true;
            else if (movement_vector.y > 0.25 || movement_vector.y < -0.25 && selectionMade)
            {
                selectionPos = false;
                selectionMade = true;
            }
            else if (movement_vector.y > -0.25 && movement_vector.y < 0.25 && selectionMade)
            {
                selectionPos = false;
                selectionMade = false;
            }

            if (movement_vector.y > 0.25 && selection == 3) selectionPos = false;
            else if (movement_vector.y < -0.25 && selection == 0) selectionPos = false;

            if (selectionPos && movement_vector.y > 0.25 && selection < 3 && !selectionMade)
            {
                selectionPos = false;
                selectionMade = true;
                selection += 1;
            }
            else if (selectionPos && movement_vector.y < -0.25 && selection > 0 && !selectionMade)
            {
                selectionPos = false;
                selectionMade = true;
                selection -= 1;
            }
        }

        switch(selection)
        {
            case 0:
                curDeg = lensGearContainer.transform.eulerAngles;
                desDeg = new Vector3(0, 0, 0);
                curDeg = Vector3.Lerp(curDeg, desDeg, Time.deltaTime * 3);
                lensGearContainer.transform.eulerAngles = curDeg;

                break;
            case 1:
                curDeg = lensGearContainer.transform.eulerAngles;
                desDeg = new Vector3(0, 0, 90);
                curDeg = Vector3.Lerp(curDeg, desDeg, Time.deltaTime * 3);
                lensGearContainer.transform.eulerAngles = curDeg;
                break;
            case 2:
                curDeg = lensGearContainer.transform.eulerAngles;
                desDeg = new Vector3(0, 0, 180);
                curDeg = Vector3.Lerp(curDeg, desDeg, Time.deltaTime * 3);
                lensGearContainer.transform.eulerAngles = curDeg;
                break;
            case 3:
                curDeg = lensGearContainer.transform.eulerAngles;
                desDeg = new Vector3(0, 0, 270);
                curDeg = Vector3.Lerp(curDeg, desDeg, Time.deltaTime * 3);
                lensGearContainer.transform.eulerAngles = curDeg;
                break;
        }

        if (shakeActive && time < shakeTime + 0.33)
        {
            enemyPortraitImage.transform.position = new Vector3(enemyPortOriginalPos.x + (float)(Random.Range(-100, 100) / 20.0f), enemyPortOriginalPos.y, enemyPortOriginalPos.z);
        }
        else
        {
            shakeActive = false;
            enemyPortraitImage.transform.position = enemyPortOriginalPos;
        }

        if (mainMenuIsActive)
        {
            if (selection == 0)
            {

                if (Input.GetKeyDown("joystick button 0") || Input.GetKeyDown(KeyCode.LeftShift))
                {
                    TurnBasedCombatStateMachine.playerUsedAbility = GameInformation.playerMoveOne;
                    TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleState.RESOLVEPLAYER;

                    shakeTime = time;
                    shakeActive = true;

                    GameInformation.PlayerAP -= GameInformation.playerMoveOne.AbilityCost;
                }
            }
            else if (selection == 1)
            {

                if (Input.GetKeyDown("joystick button 0") || Input.GetKeyDown(KeyCode.LeftShift))
                {
                    mainMenuIsActive = false;
                    abilMenuIsActive = true;

                    refTime = time;

                    /*if (Input.GetKeyDown("joystick button 0") || Input.GetKeyDown(KeyCode.LeftShift))
                    {
                        TurnBasedCombatStateMachine.playerUsedAbility = GameInformation.playerMoveTwo;
                        TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleState.RESOLVEPLAYER;

                        GameInformation.PlayerAP -= GameInformation.playerMoveTwo.AbilityCost;
                    }*/
                }
            }
            else
            {

            }
        }

        if (abilMenuIsActive)
        {
            abilDesc = "> " + GameInformation.playerMoveTwo.AbilityName;
            logLine5 = GameInformation.playerMoveTwo.AbilityDescription;

            if (time > refTime + 0.5)
            {
                if (Input.GetKeyDown("joystick button 0") || Input.GetKeyDown(KeyCode.LeftShift))
                {
                    TurnBasedCombatStateMachine.playerUsedAbility = GameInformation.playerMoveTwo;
                    TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleState.RESOLVEPLAYER;
                    GameInformation.PlayerAP -= GameInformation.playerMoveTwo.AbilityCost;

                    shakeTime = time;
                    shakeActive = true;
                }

                if (Input.GetKeyDown("joystick button 1") || Input.GetKeyDown(KeyCode.LeftControl))
                {
                    abilMenuIsActive = false;
                    mainMenuIsActive = true;
                }
            }
           }
        

        //Debug.Log(GameInformation.PlayerHealth);
        //Debug.Log(playerHealthText.text);
    }

    /*void OnGUI()
    {
        if(TurnBasedCombatStateMachine.currentState == TurnBasedCombatStateMachine.BattleState.PLAYERCHOICE)
        {// love quon
            DisplayPlayerChoice();

        }
    }

    private void DisplayPlayerChoice()
    {

        //buttons for player moves
        /*if (GUI.Button(new Rect(Screen.width - 250, Screen.height - 50, 100, 30), GameInformation.playerMoveOne.AbilityName))
        {

            //calc player damage dealt
            TurnBasedCombatStateMachine.playerUsedAbility = GameInformation.playerMoveOne;
            TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleState.RESOLVEPLAYER;

            GameInformation.PlayerAP -= GameInformation.playerMoveOne.AbilityCost;

            //GameInformation.PlayerHealth -= 10;
        }
        if (GUI.Button(new Rect(Screen.width - 150, Screen.height - 50, 100, 30), GameInformation.playerMoveTwo.AbilityName))
        {
            //calc player damage dealt
            TurnBasedCombatStateMachine.playerUsedAbility = GameInformation.playerMoveTwo;
            TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleState.RESOLVEPLAYER;

            GameInformation.PlayerAP -= GameInformation.playerMoveTwo.AbilityCost;

            //GameInformation.PlayerAP -= 15;
        }*/
        //enemy health, ap
        //player health, ap

    /*public void ShiftText(string nextLine)
    {
        logLine3 = logLine2;
        logLine2 = logLine1;
        logLine1 = nextLine;
    }*/

    IEnumerator Corout()
    {
        yield return new WaitForSeconds(1);
    }
}
