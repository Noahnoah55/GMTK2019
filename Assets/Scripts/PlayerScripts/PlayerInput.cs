﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    Vector2 lastDirection = Vector2.up;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Facer>().changeFace(lastDirection);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = getInputVector();
        if (direction != Vector2.zero)
        {
            if (GetComponent<TileMover>().attemptMove(direction))
            {
                GetComponent<SoundManager>().playsound("step");
            }
            GetComponent<Facer>().changeFace(direction);
            lastDirection = direction;
        }
        if (Input.GetButtonDown("shoot"))
        {
            GetComponent<AmmoHolder>().fireGun(lastDirection);
        }
        if (Input.GetButtonDown("RotateRight"))
        {
            lastDirection = GetComponent<Facer>().rotateFace(lastDirection, "right");
        }
        if (Input.GetButtonDown("RotateLeft"))
        {
            lastDirection = GetComponent<Facer>().rotateFace(lastDirection, "left");
        }
    }

    Vector2 getInputVector()
    {
        Vector2 direction = Vector2.zero;
        if (Input.GetButtonDown("up")) {direction = Vector2.up;}
        if (Input.GetButtonDown("down")) {direction = Vector2.down;}
        if (Input.GetButtonDown("left")) {direction = Vector2.left;}
        if (Input.GetButtonDown("right")) {direction = Vector2.right;}
        return direction;
    }
}
