﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;

    private Rigidbody player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.AddForce(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            player.AddForce(0, 0, speed * -1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.AddForce(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.AddForce(speed * -1, 0, 0);
        }
    }
}