using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    //tried and failed :(
  //  private enum size { small = 4, medium = 7 }
    public GameObject platforms;
    private GameObject player;

    public float timer
    {
        get { return timer;}
        set { timer = 0f; }
    }
    float half = 1.0f;
    float otherTimer = 0f;

    void Start()
    {
        //platforms.transform.Rotate(10, 0, 0);
        player = GameObject.Find("Player");


        //cannot get it to rotate properly for the life of me T-T

    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;
        otherTimer += Time.deltaTime;
        //my attempt at keeping the same level of difficulty as the beginning

        if (otherTimer > 30f)
        {
            half *= .2f;

            otherTimer = 0;
        }

        if (timer <= 0)
        {



            Vector3 playerInfo = player.transform.transform.position;
            Instantiate(platforms, new Vector3(Random.Range(-6f, 6f), playerInfo.y - 195.13f, playerInfo.z + 164.28f), Quaternion.identity);



            timer = Random.Range(1f * half, 5f * half);

            /*
            Quaternion randRotation = Quaternion.Euler(50, 0, 0);
            platforms.transform.localRotation = randRotation;
            */
            //deciding whether the block should be a certain size
            float blockSize = (timer % 2 == 0) ? 3 : 6;

            Vector3 randScale = new Vector3(blockSize, 5, 3);
            platforms.transform.localScale = randScale;
        }

    }
}