using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    Camera myCam;

	// Use this for initialization
	void Start ()
    {
        myCam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //myCam.orthographicSize = Screen.height / 100f / 4f;

        if(target)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x, target.position.y, transform.position.z), 0.1f);
        }
	}
}
