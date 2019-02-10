﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBreak : MonoBehaviour
{
    Rigidbody boxRb;
    public int BoxHP = 1;
    public Vector3 boxSpawnLocation;
    Vector3 moveDir;

    void Start()
    {
        boxRb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && PlayerController.isDashing)
        {
            BoxHP--;
            moveDir = other.GetComponent<PlayerController>().dir;
            if (BoxHP == 0)
            {
                gameObject.SetActive(false);
            }
        }
    }
}