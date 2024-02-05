using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playPlayer : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]
    private int horizontalSpeed;
    int newSceneTimer = 0;
    bool newSceneTimerStart;


    bool falling;




    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * 100);

    }


    private void OnCollisionEnter(Collision collision)
    {

        //if you hit an obstacle
        if (collision.gameObject.tag == "Obstacles") //if we collide with a game object whose tag is equal to ground
        {
            newSceneTimerStart = true;

        }



        if (collision.gameObject.tag == "Ground")
        {
            falling = true;
        }





    }



    // Update is called once per frame
    void Update()
    {


        if (newSceneTimerStart == true)
        {

            newSceneTimer += 1;
        }
        else
        {
            newSceneTimer = 0;
        }
        if (newSceneTimer >= 100)
        {
            newSceneTimerStart = false;

            SceneManager.LoadScene(1);

        }

        //movement
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * horizontalSpeed);

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * horizontalSpeed);

        }



        if (falling)
        {
            SceneManager.LoadScene(1);
        }

    }
}
