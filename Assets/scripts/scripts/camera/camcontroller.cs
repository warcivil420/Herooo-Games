﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcontroller : MonoBehaviour
{
    public float dumping = 1.5f;
    public Vector2 offset = new Vector2(2f, 1f);
    public bool isLeft;
    private Transform player;
    private int lastX;

    [SerializeField]
    float leftLimit;
    [SerializeField]
    float rightLimit;
    [SerializeField]
    float bottomLimit;
    [SerializeField]
    float upperLimit;

    void Start()
    {
        offset = new Vector2(Mathf.Abs(offset.x), offset.y);
        FindPlayer(isLeft);

    }


    public void FindPlayer(bool playerIsLeft)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        lastX = Mathf.RoundToInt(player.position.x);
        transform.position = new Vector3(player.position.x - offset.x, player.position.y - offset.y, transform.position.z);

    }

    void FixedUpdate()
    {
        if (player)
        {
            int currentX = Mathf.RoundToInt(player.position.x);
            lastX = Mathf.RoundToInt(player.position.x);
            Vector3 target;
            target = new Vector3(player.position.x + offset.x, player.position.y + offset.y, transform.position.z);
            Vector3 currentPosition = Vector3.Lerp(transform.position, target, dumping * Time.deltaTime);
            transform.position = currentPosition;
        }


        transform.position = new Vector3
        (
        Mathf.Clamp(transform.position.x, leftLimit+CamHelpLim.leftLimit, rightLimit+CamHelpLim.rightLimit),
        Mathf.Clamp(transform.position.y, upperLimit+CamHelpLim.upperLimit, bottomLimit+CamHelpLim.bottomLimit),
        transform.position.z
        );


    }
}


