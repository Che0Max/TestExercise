using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody rb;

    public Camera Cam;

    Vector3 movement;
    Vector3 MousePos;
    Vector3 WorldMousePos;

    void Update()
    {
        
        movement.x = Input.GetAxisRaw("Horizontal");

    }

    void OnCollisionEnter(Collision collision)
    {
            SceneManager.LoadScene(Buttons.dieScene);
    }
}
