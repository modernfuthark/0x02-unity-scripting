﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    private Camera me;
    void Start()
    {
        me = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        me.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 26, player.transform.position.z - 7);
    }
}
