﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Player game object
    private GameObject player;

    // Distance between the player and the camera
    private Vector3 offset;

    private int flag = 0;

    // Use this for initialization
    void Start()
    {

        // Store the initial distance between the player and the camera
        offset = new Vector3(0, transform.position.y - 0.75f, transform.position.z - 0);
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        if(GameObject.FindWithTag("Player") != null){
            flag = 1;
            player = GameObject.FindWithTag("Player");
        }

        if(flag == 1){

            transform.position = new Vector3(0, player.transform.position.y + offset.y, player.transform.position.z + offset.z);
        }

    }
}