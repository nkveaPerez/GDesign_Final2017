using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicToggle : MonoBehaviour {

    public AudioClip mebEn;
    public AudioClip battle;

    private GameObject playerCamera;
    public static AudioSource cameraMusic;

	void Start ()
    {
        playerCamera = GameObject.Find("Camera");

        cameraMusic = playerCamera.GetComponent<AudioSource>();
	}
	
	void Update ()
    {
		if(GameInformation.Battling)
        {
            cameraMusic.clip = battle;
            if(!GameInformation.HasBeenCheckedSinceChange)
            {
                cameraMusic.Play();
                GameInformation.HasBeenCheckedSinceChange = true;
            }
        }
        else
        {
            cameraMusic.clip = mebEn;
            if (!GameInformation.HasBeenCheckedSinceChange)
            {
                cameraMusic.Play();
                GameInformation.HasBeenCheckedSinceChange = true;
            }
        }
	}
}
