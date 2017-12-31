using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D rbody;
    Animator anim;
    Transform tform;

    private float timePassed = 0;
    private int rand;

    private bool fromSouth = true;

    // Use this for initialization
    void Start ()
    {

        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update ()
    {

        if(Input.GetKeyDown("joystick button 6") || Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        //if(timePassed == 0) print(timePassed);
        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (GameInformation.AllowedToMove)
        {
            if (movement_vector != Vector2.zero)
            {
                rand = Random.Range(1, 10);

                if (!GameInformation.IsInShop)
                {
                    if (timePassed == 0)
                    {
                        if (rand == 1 && transform.position.x > 800 && transform.position.x < 1520 && transform.position.y > 460 && transform.position.y < 1500)//Random.Range(1, 10) == 1)
                        {
                            SceneManager.LoadScene("Scenes/ImprovedBattleScene", LoadSceneMode.Additive);
                            print(rand);
                        }
                    }
                    if (timePassed > 1.5)
                    {
                        timePassed = 0;
                    }
                }

                //print(timePassed);
                timePassed += Time.deltaTime;

                anim.SetBool("isWalking", true);
                anim.SetFloat("input_y", movement_vector.y);
                anim.SetFloat("input_x", movement_vector.x);
            }
            else
            {
                anim.SetBool("isWalking", false);
                timePassed = 0;
            }

            rbody.MovePosition(rbody.position + movement_vector * Time.deltaTime * 60);

            if (!GameInformation.IsInShop)
            {
                if (transform.position.y > -30 && transform.position.y < 472 && fromSouth)
                {
                    transform.position = new Vector3(1154, 472, 0);
                    fromSouth = false;
                }
                else if (transform.position.y > -30 && transform.position.y < 472 && !fromSouth)
                {
                    transform.position = new Vector3(953, -30, 0);
                    fromSouth = true;
                }
            }

            if(transform.position.y < -23 && transform.position.y > -38 && transform.position.x > 122 && GameInformation.IsInShop && (Input.GetKeyDown("joystick button 0") || Input.GetKeyDown(KeyCode.LeftShift)))
            {
                SceneManager.LoadScene("Scenes/Start", LoadSceneMode.Single);
                GameInformation.IsInShop = false;
            }
            
            if(transform.position.y > -326 && transform.position.x > 571 && transform.position.x < 585 && !GameInformation.IsInShop && (Input.GetKeyDown("joystick button 0") || Input.GetKeyDown(KeyCode.LeftShift)))
            {
                SceneManager.LoadScene("Scenes/ShopScene", LoadSceneMode.Single);
                GameInformation.IsInShop = true;
            }

        }
        else
        {
            anim.SetBool("isWalking", false);
        }
	}
}
