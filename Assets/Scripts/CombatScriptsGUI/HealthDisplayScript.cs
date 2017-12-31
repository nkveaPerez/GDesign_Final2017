using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplayScript : MonoBehaviour {

    private float timePassed;
    private float gearTimePassed;
    
    private GameObject battleCanvas;

    private GameObject playerInfoContainer;
    private GameObject playerHealthContainer;

    private GameObject healthFilContainer0;
    private GameObject healthFilContainer1;
    private GameObject healthFilContainer2;
    private GameObject aPFilContainer0;
    private GameObject aPFilContainer1;
    private GameObject aPFilContainer2;
    private GameObject smokeContainer;

    private GameObject playerHealthValue;

    private GameObject h0_0;
    private GameObject h0_1;
    private GameObject h0_2;
    private GameObject h0_3;
    private GameObject h0_4;
    private GameObject h0_5;
    private GameObject h0_6;
    private GameObject h0_7;
    private GameObject h0_8;
    private GameObject h0_9;

    private GameObject h1_0;
    private GameObject h1_1;
    private GameObject h1_2;
    private GameObject h1_3;
    private GameObject h1_4;
    private GameObject h1_5;
    private GameObject h1_6;
    private GameObject h1_7;
    private GameObject h1_8;
    private GameObject h1_9;

    private GameObject h2_0;
    private GameObject h2_1;
    private GameObject h2_2;
    private GameObject h2_3;
    private GameObject h2_4;
    private GameObject h2_5;
    private GameObject h2_6;
    private GameObject h2_7;
    private GameObject h2_8;
    private GameObject h2_9;

    private GameObject a0_0;
    private GameObject a0_1;
    private GameObject a0_2;
    private GameObject a0_3;
    private GameObject a0_4;
    private GameObject a0_5;
    private GameObject a0_6;
    private GameObject a0_7;
    private GameObject a0_8;
    private GameObject a0_9;

    private GameObject a1_0;
    private GameObject a1_1;
    private GameObject a1_2;
    private GameObject a1_3;
    private GameObject a1_4;
    private GameObject a1_5;
    private GameObject a1_6;
    private GameObject a1_7;
    private GameObject a1_8;
    private GameObject a1_9;

    private GameObject a2_0;
    private GameObject a2_1;
    private GameObject a2_2;
    private GameObject a2_3;
    private GameObject a2_4;
    private GameObject a2_5;
    private GameObject a2_6;
    private GameObject a2_7;
    private GameObject a2_8;
    private GameObject a2_9;

    private GameObject smok1;
    private GameObject smok2;
    private GameObject smok3;

    private GameObject gear;
    private Vector3 curDeg = new Vector3();
    private Vector3 desDeg = new Vector3();

    private GameObject apSym;
    private Vector3 apCurDeg = new Vector3();
    private Vector3 modDeg = new Vector3(0, 0, 0);
    private Vector3 apDesDeg = new Vector3(0, 0, 0);

    private int health;
    private int healthHuns, healthTens, healthOnes;

    private int ap;
    private int apHuns, apTens, apOnes;

	public void HealthInit ()
    {
        battleCanvas = GameObject.Find("BattleCanvas");

        playerInfoContainer = battleCanvas.transform.Find("PlayerInfoContainer").gameObject;
        playerHealthContainer = playerInfoContainer.transform.Find("PlayerHealthContainer").gameObject;

        healthFilContainer0 = playerHealthContainer.transform.Find("HealthFilContainer0").gameObject;
        healthFilContainer1 = playerHealthContainer.transform.Find("HealthFilContainer1").gameObject;
        healthFilContainer2 = playerHealthContainer.transform.Find("HealthFilContainer2").gameObject;
        aPFilContainer0 = playerHealthContainer.transform.Find("APFilContainer0").gameObject;
        aPFilContainer1 = playerHealthContainer.transform.Find("APFilContainer1").gameObject;
        aPFilContainer2 = playerHealthContainer.transform.Find("APFilContainer2").gameObject;
        smokeContainer = playerHealthContainer.transform.Find("SmokeContainer").gameObject;

        if (true)
        {
            h0_0 = healthFilContainer0.transform.Find("LA-0-0").gameObject;
            h0_1 = healthFilContainer0.transform.Find("LA-0-1").gameObject;
            h0_2 = healthFilContainer0.transform.Find("LA-0-2").gameObject;
            h0_3 = healthFilContainer0.transform.Find("LA-0-3").gameObject;
            h0_4 = healthFilContainer0.transform.Find("LA-0-4").gameObject;
            h0_5 = healthFilContainer0.transform.Find("LA-0-5").gameObject;
            h0_6 = healthFilContainer0.transform.Find("LA-0-6").gameObject;
            h0_7 = healthFilContainer0.transform.Find("LA-0-7").gameObject;
            h0_8 = healthFilContainer0.transform.Find("LA-0-8").gameObject;
            h0_9 = healthFilContainer0.transform.Find("LA-0-9").gameObject;

            h1_0 = healthFilContainer1.transform.Find("LA-0-0").gameObject;
            h1_1 = healthFilContainer1.transform.Find("LA-0-1").gameObject;
            h1_2 = healthFilContainer1.transform.Find("LA-0-2").gameObject;
            h1_3 = healthFilContainer1.transform.Find("LA-0-3").gameObject;
            h1_4 = healthFilContainer1.transform.Find("LA-0-4").gameObject;
            h1_5 = healthFilContainer1.transform.Find("LA-0-5").gameObject;
            h1_6 = healthFilContainer1.transform.Find("LA-0-6").gameObject;
            h1_7 = healthFilContainer1.transform.Find("LA-0-7").gameObject;
            h1_8 = healthFilContainer1.transform.Find("LA-0-8").gameObject;
            h1_9 = healthFilContainer1.transform.Find("LA-0-9").gameObject;

            h2_0 = healthFilContainer2.transform.Find("LA-0-0").gameObject;
            h2_1 = healthFilContainer2.transform.Find("LA-0-1").gameObject;
            h2_2 = healthFilContainer2.transform.Find("LA-0-2").gameObject;
            h2_3 = healthFilContainer2.transform.Find("LA-0-3").gameObject;
            h2_4 = healthFilContainer2.transform.Find("LA-0-4").gameObject;
            h2_5 = healthFilContainer2.transform.Find("LA-0-5").gameObject;
            h2_6 = healthFilContainer2.transform.Find("LA-0-6").gameObject;
            h2_7 = healthFilContainer2.transform.Find("LA-0-7").gameObject;
            h2_8 = healthFilContainer2.transform.Find("LA-0-8").gameObject;
            h2_9 = healthFilContainer2.transform.Find("LA-0-9").gameObject;

            a0_0 = aPFilContainer0.transform.Find("LA-0-0").gameObject;
            a0_1 = aPFilContainer0.transform.Find("LA-0-1").gameObject;
            a0_2 = aPFilContainer0.transform.Find("LA-0-2").gameObject;
            a0_3 = aPFilContainer0.transform.Find("LA-0-3").gameObject;
            a0_4 = aPFilContainer0.transform.Find("LA-0-4").gameObject;
            a0_5 = aPFilContainer0.transform.Find("LA-0-5").gameObject;
            a0_6 = aPFilContainer0.transform.Find("LA-0-6").gameObject;
            a0_7 = aPFilContainer0.transform.Find("LA-0-7").gameObject;
            a0_8 = aPFilContainer0.transform.Find("LA-0-8").gameObject;
            a0_9 = aPFilContainer0.transform.Find("LA-0-9").gameObject;

            a1_0 = aPFilContainer1.transform.Find("LA-0-0").gameObject;
            a1_1 = aPFilContainer1.transform.Find("LA-0-1").gameObject;
            a1_2 = aPFilContainer1.transform.Find("LA-0-2").gameObject;
            a1_3 = aPFilContainer1.transform.Find("LA-0-3").gameObject;
            a1_4 = aPFilContainer1.transform.Find("LA-0-4").gameObject;
            a1_5 = aPFilContainer1.transform.Find("LA-0-5").gameObject;
            a1_6 = aPFilContainer1.transform.Find("LA-0-6").gameObject;
            a1_7 = aPFilContainer1.transform.Find("LA-0-7").gameObject;
            a1_8 = aPFilContainer1.transform.Find("LA-0-8").gameObject;
            a1_9 = aPFilContainer1.transform.Find("LA-0-9").gameObject;

            a2_0 = aPFilContainer2.transform.Find("LA-0-0").gameObject;
            a2_1 = aPFilContainer2.transform.Find("LA-0-1").gameObject;
            a2_2 = aPFilContainer2.transform.Find("LA-0-2").gameObject;
            a2_3 = aPFilContainer2.transform.Find("LA-0-3").gameObject;
            a2_4 = aPFilContainer2.transform.Find("LA-0-4").gameObject;
            a2_5 = aPFilContainer2.transform.Find("LA-0-5").gameObject;
            a2_6 = aPFilContainer2.transform.Find("LA-0-6").gameObject;
            a2_7 = aPFilContainer2.transform.Find("LA-0-7").gameObject;
            a2_8 = aPFilContainer2.transform.Find("LA-0-8").gameObject;
            a2_9 = aPFilContainer2.transform.Find("LA-0-9").gameObject;

            smok1 = smokeContainer.transform.Find("Smok1").gameObject;
            smok2 = smokeContainer.transform.Find("Smok2").gameObject;
            smok3 = smokeContainer.transform.Find("Smok3").gameObject;

            gear = playerHealthContainer.transform.Find("TopRight_Gear").gameObject;

            apSym = playerHealthContainer.transform.Find("MP").gameObject;
        } //just so i can collapse this shit lmao
    }
	
	public void HealthUpdate ()
    {
        timePassed += Time.deltaTime;
        gearTimePassed += Time.deltaTime;

        curDeg = gear.transform.eulerAngles;
        desDeg = new Vector3(curDeg.x, curDeg.y, curDeg.z - 1);
        curDeg = Vector3.Lerp(curDeg, desDeg, Time.deltaTime * 36);
        gear.transform.eulerAngles = curDeg;

        modDeg = apSym.transform.eulerAngles;
        apCurDeg = apSym.transform.eulerAngles;
        if(modDeg.z > apDesDeg.z - 3 && modDeg.z < apDesDeg.z + 3)
        {
            apDesDeg = new Vector3(apCurDeg.x, apCurDeg.y, Random.Range(0, 360));
        }
        apCurDeg = Vector3.Lerp(apCurDeg, apDesDeg, Time.deltaTime * 1);
        apSym.transform.eulerAngles = apCurDeg;

        if (timePassed >= 0 && timePassed < 0.2)
        {
            smok1.SetActive(true);
            smok2.SetActive(true);
            smok3.SetActive(false);
        }
        else if(timePassed >= 0.2 && timePassed < 0.4)
        {
            smok1.SetActive(false);
            smok2.SetActive(true);
            smok3.SetActive(true);
        }
        else if(timePassed >= 0.4 && timePassed < 0.6)
        {
            smok1.SetActive(true);
            smok2.SetActive(false);
            smok3.SetActive(true);
        }
        else if(timePassed >= 0.6)
        {
            timePassed = 0;
        }

        health = GameInformation.PlayerHealth;
        ap = GameInformation.PlayerAP;

        /*if(Input.GetKey(KeyCode.DownArrow))
        {
            GameInformation.PlayerHealth -= 1;
        }
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            GameInformation.PlayerHealth += 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            GameInformation.PlayerAP -= 1;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            GameInformation.PlayerAP += 1;
        }*/

        if (health > 99 && health < 1000)
        {
            healthHuns = (int)(health / 100);
            healthTens = (int)((health - healthHuns * 100) / 10);
            healthOnes = health - healthHuns * 100 - healthTens * 10;

            HundredsWriteHealth(healthHuns);
            TensWriteHealth(healthTens);
            OnesWriteHealth(healthOnes);
        }
        else if(health > 9 && health < 100)
        {
            healthHuns = 0;

            healthTens = (int)(health / 10);
            healthOnes = health - healthTens * 10;

            HundredsWriteHealth(healthHuns);
            TensWriteHealth(healthTens);
            OnesWriteHealth(healthOnes);
        }
        else if(health < 10 && health > -1)
        {
            healthHuns = 0;
            healthTens = 0;

            healthOnes = health;

            HundredsWriteHealth(healthHuns);
            TensWriteHealth(healthTens);
            OnesWriteHealth(healthOnes);
        }

        if (ap > 99 && ap < 1000)
        {
            apHuns = (int)(ap / 100);
            apTens = (int)((ap - apHuns * 100) / 10);
            apOnes = ap - apHuns * 100 - apTens * 10;

            HundredsWriteAP(apHuns);
            TensWriteAP(apTens);
            OnesWriteAP(apOnes);
        }
        else if (ap > 9 && ap < 100)
        {
            apHuns = 0;

            apTens = (int)(ap / 10);
            apOnes = ap - apTens * 10;

            HundredsWriteAP(apHuns);
            TensWriteAP(apTens);
            OnesWriteAP(apOnes);
        }
        else if (ap < 10 && ap > -1)
        {
            apHuns = 0;
            apTens = 0;

            apOnes = ap;

            HundredsWriteAP(apHuns);
            TensWriteAP(apTens);
            OnesWriteAP(apOnes);
        }
    }

    private void HundredsWriteHealth(int hundredsPlace)
    {
        switch(hundredsPlace)
        {
            case 0:
                h0_0.SetActive(true);
                h0_1.SetActive(false);
                h0_2.SetActive(false);
                h0_3.SetActive(false);
                h0_4.SetActive(false);
                h0_5.SetActive(false);
                h0_6.SetActive(false);
                h0_7.SetActive(false);
                h0_8.SetActive(false);
                h0_9.SetActive(false);
                break;
            case 1:
                h0_0.SetActive(false);
                h0_1.SetActive(true);
                h0_2.SetActive(false);
                h0_3.SetActive(false);
                h0_4.SetActive(false);
                h0_5.SetActive(false);
                h0_6.SetActive(false);
                h0_7.SetActive(false);
                h0_8.SetActive(false);
                h0_9.SetActive(false);
                break;
            case 2:
                h0_0.SetActive(false);
                h0_1.SetActive(false);
                h0_2.SetActive(true);
                h0_3.SetActive(false);
                h0_4.SetActive(false);
                h0_5.SetActive(false);
                h0_6.SetActive(false);
                h0_7.SetActive(false);
                h0_8.SetActive(false);
                h0_9.SetActive(false);
                break;
            case 3:
                h0_0.SetActive(false);
                h0_1.SetActive(false);
                h0_2.SetActive(false);
                h0_3.SetActive(true);
                h0_4.SetActive(false);
                h0_5.SetActive(false);
                h0_6.SetActive(false);
                h0_7.SetActive(false);
                h0_8.SetActive(false);
                h0_9.SetActive(false);
                break;
            case 4:
                h0_0.SetActive(false);
                h0_1.SetActive(false);
                h0_2.SetActive(false);
                h0_3.SetActive(false);
                h0_4.SetActive(true);
                h0_5.SetActive(false);
                h0_6.SetActive(false);
                h0_7.SetActive(false);
                h0_8.SetActive(false);
                h0_9.SetActive(false);
                break;
            case 5:
                h0_0.SetActive(false);
                h0_1.SetActive(false);
                h0_2.SetActive(false);
                h0_3.SetActive(false);
                h0_4.SetActive(false);
                h0_5.SetActive(true);
                h0_6.SetActive(false);
                h0_7.SetActive(false);
                h0_8.SetActive(false);
                h0_9.SetActive(false);
                break;
            case 6:
                h0_0.SetActive(false);
                h0_1.SetActive(false);
                h0_2.SetActive(false);
                h0_3.SetActive(false);
                h0_4.SetActive(false);
                h0_5.SetActive(false);
                h0_6.SetActive(true);
                h0_7.SetActive(false);
                h0_8.SetActive(false);
                h0_9.SetActive(false);
                break;
            case 7:
                h0_0.SetActive(false);
                h0_1.SetActive(false);
                h0_2.SetActive(false);
                h0_3.SetActive(false);
                h0_4.SetActive(false);
                h0_5.SetActive(false);
                h0_6.SetActive(false);
                h0_7.SetActive(true);
                h0_8.SetActive(false);
                h0_9.SetActive(false);
                break;
            case 8:
                h0_0.SetActive(false);
                h0_1.SetActive(false);
                h0_2.SetActive(false);
                h0_3.SetActive(false);
                h0_4.SetActive(false);
                h0_5.SetActive(false);
                h0_6.SetActive(false);
                h0_7.SetActive(false);
                h0_8.SetActive(true);
                h0_9.SetActive(false);
                break;
            case 9:
                h0_0.SetActive(false);
                h0_1.SetActive(false);
                h0_2.SetActive(false);
                h0_3.SetActive(false);
                h0_4.SetActive(false);
                h0_5.SetActive(false);
                h0_6.SetActive(false);
                h0_7.SetActive(false);
                h0_8.SetActive(false);
                h0_9.SetActive(true);
                break;
        }
    }

    private void TensWriteHealth(int tensPlace)
    {
        switch (tensPlace)
        {
            case 0:
                h1_0.SetActive(true);
                h1_1.SetActive(false);
                h1_2.SetActive(false);
                h1_3.SetActive(false);
                h1_4.SetActive(false);
                h1_5.SetActive(false);
                h1_6.SetActive(false);
                h1_7.SetActive(false);
                h1_8.SetActive(false);
                h1_9.SetActive(false);
                break;
            case 1:
                h1_0.SetActive(false);
                h1_1.SetActive(true);
                h1_2.SetActive(false);
                h1_3.SetActive(false);
                h1_4.SetActive(false);
                h1_5.SetActive(false);
                h1_6.SetActive(false);
                h1_7.SetActive(false);
                h1_8.SetActive(false);
                h1_9.SetActive(false);
                break;
            case 2:
                h1_0.SetActive(false);
                h1_1.SetActive(false);
                h1_2.SetActive(true);
                h1_3.SetActive(false);
                h1_4.SetActive(false);
                h1_5.SetActive(false);
                h1_6.SetActive(false);
                h1_7.SetActive(false);
                h1_8.SetActive(false);
                h1_9.SetActive(false);
                break;
            case 3:
                h1_0.SetActive(false);
                h1_1.SetActive(false);
                h1_2.SetActive(false);
                h1_3.SetActive(true);
                h1_4.SetActive(false);
                h1_5.SetActive(false);
                h1_6.SetActive(false);
                h1_7.SetActive(false);
                h1_8.SetActive(false);
                h1_9.SetActive(false);
                break;
            case 4:
                h1_0.SetActive(false);
                h1_1.SetActive(false);
                h1_2.SetActive(false);
                h1_3.SetActive(false);
                h1_4.SetActive(true);
                h1_5.SetActive(false);
                h1_6.SetActive(false);
                h1_7.SetActive(false);
                h1_8.SetActive(false);
                h1_9.SetActive(false);
                break;
            case 5:
                h1_0.SetActive(false);
                h1_1.SetActive(false);
                h1_2.SetActive(false);
                h1_3.SetActive(false);
                h1_4.SetActive(false);
                h1_5.SetActive(true);
                h1_6.SetActive(false);
                h1_7.SetActive(false);
                h1_8.SetActive(false);
                h1_9.SetActive(false);
                break;
            case 6:
                h1_0.SetActive(false);
                h1_1.SetActive(false);
                h1_2.SetActive(false);
                h1_3.SetActive(false);
                h1_4.SetActive(false);
                h1_5.SetActive(false);
                h1_6.SetActive(true);
                h1_7.SetActive(false);
                h1_8.SetActive(false);
                h1_9.SetActive(false);
                break;
            case 7:
                h1_0.SetActive(false);
                h1_1.SetActive(false);
                h1_2.SetActive(false);
                h1_3.SetActive(false);
                h1_4.SetActive(false);
                h1_5.SetActive(false);
                h1_6.SetActive(false);
                h1_7.SetActive(true);
                h1_8.SetActive(false);
                h1_9.SetActive(false);
                break;
            case 8:
                h1_0.SetActive(false);
                h1_1.SetActive(false);
                h1_2.SetActive(false);
                h1_3.SetActive(false);
                h1_4.SetActive(false);
                h1_5.SetActive(false);
                h1_6.SetActive(false);
                h1_7.SetActive(false);
                h1_8.SetActive(true);
                h1_9.SetActive(false);
                break;
            case 9:
                h1_0.SetActive(false);
                h1_1.SetActive(false);
                h1_2.SetActive(false);
                h1_3.SetActive(false);
                h1_4.SetActive(false);
                h1_5.SetActive(false);
                h1_6.SetActive(false);
                h1_7.SetActive(false);
                h1_8.SetActive(false);
                h1_9.SetActive(true);
                break;
        }
    }

    private void OnesWriteHealth(int onesPlace)
    {
        switch (onesPlace)
        {
            case 0:
                h2_0.SetActive(true);
                h2_1.SetActive(false);
                h2_2.SetActive(false);
                h2_3.SetActive(false);
                h2_4.SetActive(false);
                h2_5.SetActive(false);
                h2_6.SetActive(false);
                h2_7.SetActive(false);
                h2_8.SetActive(false);
                h2_9.SetActive(false);
                break;
            case 1:
                h2_0.SetActive(false);
                h2_1.SetActive(true);
                h2_2.SetActive(false);
                h2_3.SetActive(false);
                h2_4.SetActive(false);
                h2_5.SetActive(false);
                h2_6.SetActive(false);
                h2_7.SetActive(false);
                h2_8.SetActive(false);
                h2_9.SetActive(false);
                break;
            case 2:
                h2_0.SetActive(false);
                h2_1.SetActive(false);
                h2_2.SetActive(true);
                h2_3.SetActive(false);
                h2_4.SetActive(false);
                h2_5.SetActive(false);
                h2_6.SetActive(false);
                h2_7.SetActive(false);
                h2_8.SetActive(false);
                h2_9.SetActive(false);
                break;
            case 3:
                h2_0.SetActive(false);
                h2_1.SetActive(false);
                h2_2.SetActive(false);
                h2_3.SetActive(true);
                h2_4.SetActive(false);
                h2_5.SetActive(false);
                h2_6.SetActive(false);
                h2_7.SetActive(false);
                h2_8.SetActive(false);
                h2_9.SetActive(false);
                break;
            case 4:
                h2_0.SetActive(false);
                h2_1.SetActive(false);
                h2_2.SetActive(false);
                h2_3.SetActive(false);
                h2_4.SetActive(true);
                h2_5.SetActive(false);
                h2_6.SetActive(false);
                h2_7.SetActive(false);
                h2_8.SetActive(false);
                h2_9.SetActive(false);
                break;
            case 5:
                h2_0.SetActive(false);
                h2_1.SetActive(false);
                h2_2.SetActive(false);
                h2_3.SetActive(false);
                h2_4.SetActive(false);
                h2_5.SetActive(true);
                h2_6.SetActive(false);
                h2_7.SetActive(false);
                h2_8.SetActive(false);
                h2_9.SetActive(false);
                break;
            case 6:
                h2_0.SetActive(false);
                h2_1.SetActive(false);
                h2_2.SetActive(false);
                h2_3.SetActive(false);
                h2_4.SetActive(false);
                h2_5.SetActive(false);
                h2_6.SetActive(true);
                h2_7.SetActive(false);
                h2_8.SetActive(false);
                h2_9.SetActive(false);
                break;
            case 7:
                h2_0.SetActive(false);
                h2_1.SetActive(false);
                h2_2.SetActive(false);
                h2_3.SetActive(false);
                h2_4.SetActive(false);
                h2_5.SetActive(false);
                h2_6.SetActive(false);
                h2_7.SetActive(true);
                h2_8.SetActive(false);
                h2_9.SetActive(false);
                break;
            case 8:
                h2_0.SetActive(false);
                h2_1.SetActive(false);
                h2_2.SetActive(false);
                h2_3.SetActive(false);
                h2_4.SetActive(false);
                h2_5.SetActive(false);
                h2_6.SetActive(false);
                h2_7.SetActive(false);
                h2_8.SetActive(true);
                h2_9.SetActive(false);
                break;
            case 9:
                h2_0.SetActive(false);
                h2_1.SetActive(false);
                h2_2.SetActive(false);
                h2_3.SetActive(false);
                h2_4.SetActive(false);
                h2_5.SetActive(false);
                h2_6.SetActive(false);
                h2_7.SetActive(false);
                h2_8.SetActive(false);
                h2_9.SetActive(true);
                break;
        }
    }

    private void HundredsWriteAP(int hundredsPlace)
    {
        switch (hundredsPlace)
        {
            case 0:
                a0_0.SetActive(true);
                a0_1.SetActive(false);
                a0_2.SetActive(false);
                a0_3.SetActive(false);
                a0_4.SetActive(false);
                a0_5.SetActive(false);
                a0_6.SetActive(false);
                a0_7.SetActive(false);
                a0_8.SetActive(false);
                a0_9.SetActive(false);
                break;
            case 1:
                a0_0.SetActive(false);
                a0_1.SetActive(true);
                a0_2.SetActive(false);
                a0_3.SetActive(false);
                a0_4.SetActive(false);
                a0_5.SetActive(false);
                a0_6.SetActive(false);
                a0_7.SetActive(false);
                a0_8.SetActive(false);
                a0_9.SetActive(false);
                break;
            case 2:
                a0_0.SetActive(false);
                a0_1.SetActive(false);
                a0_2.SetActive(true);
                a0_3.SetActive(false);
                a0_4.SetActive(false);
                a0_5.SetActive(false);
                a0_6.SetActive(false);
                a0_7.SetActive(false);
                a0_8.SetActive(false);
                a0_9.SetActive(false);
                break;
            case 3:
                a0_0.SetActive(false);
                a0_1.SetActive(false);
                a0_2.SetActive(false);
                a0_3.SetActive(true);
                a0_4.SetActive(false);
                a0_5.SetActive(false);
                a0_6.SetActive(false);
                a0_7.SetActive(false);
                a0_8.SetActive(false);
                a0_9.SetActive(false);
                break;
            case 4:
                a0_0.SetActive(false);
                a0_1.SetActive(false);
                a0_2.SetActive(false);
                a0_3.SetActive(false);
                a0_4.SetActive(true);
                a0_5.SetActive(false);
                a0_6.SetActive(false);
                a0_7.SetActive(false);
                a0_8.SetActive(false);
                a0_9.SetActive(false);
                break;
            case 5:
                a0_0.SetActive(false);
                a0_1.SetActive(false);
                a0_2.SetActive(false);
                a0_3.SetActive(false);
                a0_4.SetActive(false);
                a0_5.SetActive(true);
                a0_6.SetActive(false);
                a0_7.SetActive(false);
                a0_8.SetActive(false);
                a0_9.SetActive(false);
                break;
            case 6:
                a0_0.SetActive(false);
                a0_1.SetActive(false);
                a0_2.SetActive(false);
                a0_3.SetActive(false);
                a0_4.SetActive(false);
                a0_5.SetActive(false);
                a0_6.SetActive(true);
                a0_7.SetActive(false);
                a0_8.SetActive(false);
                a0_9.SetActive(false);
                break;
            case 7:
                a0_0.SetActive(false);
                a0_1.SetActive(false);
                a0_2.SetActive(false);
                a0_3.SetActive(false);
                a0_4.SetActive(false);
                a0_5.SetActive(false);
                a0_6.SetActive(false);
                a0_7.SetActive(true);
                a0_8.SetActive(false);
                a0_9.SetActive(false);
                break;
            case 8:
                a0_0.SetActive(false);
                a0_1.SetActive(false);
                a0_2.SetActive(false);
                a0_3.SetActive(false);
                a0_4.SetActive(false);
                a0_5.SetActive(false);
                a0_6.SetActive(false);
                a0_7.SetActive(false);
                a0_8.SetActive(true);
                a0_9.SetActive(false);
                break;
            case 9:
                a0_0.SetActive(false);
                a0_1.SetActive(false);
                a0_2.SetActive(false);
                a0_3.SetActive(false);
                a0_4.SetActive(false);
                a0_5.SetActive(false);
                a0_6.SetActive(false);
                a0_7.SetActive(false);
                a0_8.SetActive(false);
                a0_9.SetActive(true);
                break;
        }
    }

    private void TensWriteAP(int tensPlace)
    {
        switch (tensPlace)
        {
            case 0:
                a1_0.SetActive(true);
                a1_1.SetActive(false);
                a1_2.SetActive(false);
                a1_3.SetActive(false);
                a1_4.SetActive(false);
                a1_5.SetActive(false);
                a1_6.SetActive(false);
                a1_7.SetActive(false);
                a1_8.SetActive(false);
                a1_9.SetActive(false);
                break;
            case 1:
                a1_0.SetActive(false);
                a1_1.SetActive(true);
                a1_2.SetActive(false);
                a1_3.SetActive(false);
                a1_4.SetActive(false);
                a1_5.SetActive(false);
                a1_6.SetActive(false);
                a1_7.SetActive(false);
                a1_8.SetActive(false);
                a1_9.SetActive(false);
                break;
            case 2:
                a1_0.SetActive(false);
                a1_1.SetActive(false);
                a1_2.SetActive(true);
                a1_3.SetActive(false);
                a1_4.SetActive(false);
                a1_5.SetActive(false);
                a1_6.SetActive(false);
                a1_7.SetActive(false);
                a1_8.SetActive(false);
                a1_9.SetActive(false);
                break;
            case 3:
                a1_0.SetActive(false);
                a1_1.SetActive(false);
                a1_2.SetActive(false);
                a1_3.SetActive(true);
                a1_4.SetActive(false);
                a1_5.SetActive(false);
                a1_6.SetActive(false);
                a1_7.SetActive(false);
                a1_8.SetActive(false);
                a1_9.SetActive(false);
                break;
            case 4:
                a1_0.SetActive(false);
                a1_1.SetActive(false);
                a1_2.SetActive(false);
                a1_3.SetActive(false);
                a1_4.SetActive(true);
                a1_5.SetActive(false);
                a1_6.SetActive(false);
                a1_7.SetActive(false);
                a1_8.SetActive(false);
                a1_9.SetActive(false);
                break;
            case 5:
                a1_0.SetActive(false);
                a1_1.SetActive(false);
                a1_2.SetActive(false);
                a1_3.SetActive(false);
                a1_4.SetActive(false);
                a1_5.SetActive(true);
                a1_6.SetActive(false);
                a1_7.SetActive(false);
                a1_8.SetActive(false);
                a1_9.SetActive(false);
                break;
            case 6:
                a1_0.SetActive(false);
                a1_1.SetActive(false);
                a1_2.SetActive(false);
                a1_3.SetActive(false);
                a1_4.SetActive(false);
                a1_5.SetActive(false);
                a1_6.SetActive(true);
                a1_7.SetActive(false);
                a1_8.SetActive(false);
                a1_9.SetActive(false);
                break;
            case 7:
                a1_0.SetActive(false);
                a1_1.SetActive(false);
                a1_2.SetActive(false);
                a1_3.SetActive(false);
                a1_4.SetActive(false);
                a1_5.SetActive(false);
                a1_6.SetActive(false);
                a1_7.SetActive(true);
                a1_8.SetActive(false);
                a1_9.SetActive(false);
                break;
            case 8:
                a1_0.SetActive(false);
                a1_1.SetActive(false);
                a1_2.SetActive(false);
                a1_3.SetActive(false);
                a1_4.SetActive(false);
                a1_5.SetActive(false);
                a1_6.SetActive(false);
                a1_7.SetActive(false);
                a1_8.SetActive(true);
                a1_9.SetActive(false);
                break;
            case 9:
                a1_0.SetActive(false);
                a1_1.SetActive(false);
                a1_2.SetActive(false);
                a1_3.SetActive(false);
                a1_4.SetActive(false);
                a1_5.SetActive(false);
                a1_6.SetActive(false);
                a1_7.SetActive(false);
                a1_8.SetActive(false);
                a1_9.SetActive(true);
                break;
        }
    }

    private void OnesWriteAP(int onesPlace)
    {
        switch (onesPlace)
        {
            case 0:
                a2_0.SetActive(true);
                a2_1.SetActive(false);
                a2_2.SetActive(false);
                a2_3.SetActive(false);
                a2_4.SetActive(false);
                a2_5.SetActive(false);
                a2_6.SetActive(false);
                a2_7.SetActive(false);
                a2_8.SetActive(false);
                a2_9.SetActive(false);
                break;
            case 1:
                a2_0.SetActive(false);
                a2_1.SetActive(true);
                a2_2.SetActive(false);
                a2_3.SetActive(false);
                a2_4.SetActive(false);
                a2_5.SetActive(false);
                a2_6.SetActive(false);
                a2_7.SetActive(false);
                a2_8.SetActive(false);
                a2_9.SetActive(false);
                break;
            case 2:
                a2_0.SetActive(false);
                a2_1.SetActive(false);
                a2_2.SetActive(true);
                a2_3.SetActive(false);
                a2_4.SetActive(false);
                a2_5.SetActive(false);
                a2_6.SetActive(false);
                a2_7.SetActive(false);
                a2_8.SetActive(false);
                a2_9.SetActive(false);
                break;
            case 3:
                a2_0.SetActive(false);
                a2_1.SetActive(false);
                a2_2.SetActive(false);
                a2_3.SetActive(true);
                a2_4.SetActive(false);
                a2_5.SetActive(false);
                a2_6.SetActive(false);
                a2_7.SetActive(false);
                a2_8.SetActive(false);
                a2_9.SetActive(false);
                break;
            case 4:
                a2_0.SetActive(false);
                a2_1.SetActive(false);
                a2_2.SetActive(false);
                a2_3.SetActive(false);
                a2_4.SetActive(true);
                a2_5.SetActive(false);
                a2_6.SetActive(false);
                a2_7.SetActive(false);
                a2_8.SetActive(false);
                a2_9.SetActive(false);
                break;
            case 5:
                a2_0.SetActive(false);
                a2_1.SetActive(false);
                a2_2.SetActive(false);
                a2_3.SetActive(false);
                a2_4.SetActive(false);
                a2_5.SetActive(true);
                a2_6.SetActive(false);
                a2_7.SetActive(false);
                a2_8.SetActive(false);
                a2_9.SetActive(false);
                break;
            case 6:
                a2_0.SetActive(false);
                a2_1.SetActive(false);
                a2_2.SetActive(false);
                a2_3.SetActive(false);
                a2_4.SetActive(false);
                a2_5.SetActive(false);
                a2_6.SetActive(true);
                a2_7.SetActive(false);
                a2_8.SetActive(false);
                a2_9.SetActive(false);
                break;
            case 7:
                a2_0.SetActive(false);
                a2_1.SetActive(false);
                a2_2.SetActive(false);
                a2_3.SetActive(false);
                a2_4.SetActive(false);
                a2_5.SetActive(false);
                a2_6.SetActive(false);
                a2_7.SetActive(true);
                a2_8.SetActive(false);
                a2_9.SetActive(false);
                break;
            case 8:
                a2_0.SetActive(false);
                a2_1.SetActive(false);
                a2_2.SetActive(false);
                a2_3.SetActive(false);
                a2_4.SetActive(false);
                a2_5.SetActive(false);
                a2_6.SetActive(false);
                a2_7.SetActive(false);
                a2_8.SetActive(true);
                a2_9.SetActive(false);
                break;
            case 9:
                a2_0.SetActive(false);
                a2_1.SetActive(false);
                a2_2.SetActive(false);
                a2_3.SetActive(false);
                a2_4.SetActive(false);
                a2_5.SetActive(false);
                a2_6.SetActive(false);
                a2_7.SetActive(false);
                a2_8.SetActive(false);
                a2_9.SetActive(true);
                break;
        }
    }
}
