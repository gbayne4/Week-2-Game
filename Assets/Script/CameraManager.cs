using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public float cameraDistOffsetZ;
    public float cameraDistOffsetY;
    private Camera mainCamera;
    private GameObject player;

    void Start()
    {
        //locating the player
        mainCamera = GetComponent<Camera>();
        player = GameObject.Find("Player");
    }


    void Update()
    {
        //changing the camera to follow the player
        Vector3 playerInfo = player.transform.transform.position;
        mainCamera.transform.position = new Vector3(playerInfo.x, playerInfo.y + cameraDistOffsetY, playerInfo.z - cameraDistOffsetZ);
    }
}
