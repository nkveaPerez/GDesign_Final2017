using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadingTeleporter : MonoBehaviour
{
    public Renderer tar;
    public GameObject player;

    private bool fading = false;

    public int xCoords;
    public int yCoords;

    private float timePassed;

    public int XCoords
    {
        get { return xCoords; }
        set { xCoords = value; }
    }
    public int YCoords
    {
        get { return yCoords; }
        set { yCoords = value; }
    }

    private float colorFade;

    void Start ()
    {
		
	}
	
	void Update ()
    {
        timePassed += Time.deltaTime;
        if (fading)
        {
            if (timePassed < 1)
            {
                tar.GetComponent<Renderer>().material.color = new Vector4(0, 0, 0, timePassed);
            }
            else if(timePassed >= 1 && timePassed < 3)
            {
                tar.GetComponent<Renderer>().material.color = new Vector4(0, 0, 0, 1);
            }
            else if(timePassed >= 3 && timePassed < 4)
            {
                tar.GetComponent<Renderer>().material.color = new Vector4(0, 0, 0, colorFade -= Time.deltaTime);
            }
            else
            {
                fading = false;
                GameInformation.AllowedToMove = true;
            }
        }
	}

    void OnCollisionEnter(Collision otherObject)
    {
        print("MET");

        if (otherObject.gameObject == player)
        {
            fading = true;
            colorFade = 1;
            timePassed = 0;
            GameInformation.AllowedToMove = false;

            //if (timePassed > 1 && timePassed < 1.15)
            //{
                Vector3 newPos = otherObject.gameObject.transform.position;
                newPos = new Vector3(xCoords, yCoords, 0);
                otherObject.gameObject.transform.position = newPos;
            //}
        }
    }
}
