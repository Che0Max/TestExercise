using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;


public class Zombie : MonoBehaviour
{

    public GameObject Zomb;

    public Transform player;
    public Vector3 direction;
    private Rigidbody rb;
    
    String Name;

    public int HP;

    private int HPSmall = 10;
    private int HPLarge = 50;

    private float speed = 0.0005f;
    private float SmallSpeed = 2f;
    private float MediumSpeed = 3f;
    private float LargeSpeed = 1f;
    



    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();

        //direction = Vector3.forward;
        Name = Zomb.name;

        switch (Name)
        {
            case ("Small"or"Small(Clone)"):
                HP = HPSmall;
                speed *= SmallSpeed;
                break;
            case ("Medium" or "Medium(Clone)"):
                HP = HPSmall;
                speed *= MediumSpeed;
                break;
            case ("Large" or "Large(Clone)"):
                HP = HPLarge;
                speed *= LargeSpeed;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 WMPosition = player.position;
        Vector3 diff = WMPosition - transform.position;
        float rotateY = Mathf.Atan2(diff.z, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, -rotateY + 90f, 0f);
        transform.Translate(Vector3.forward * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        
        /*if (collision.gameObject.name == "Firing Rifle")
        {
            SceneManager.LoadScene(Buttons.mainScene);
        }

        Debug.Log(collision.gameObject.name);*/
        InHit();
    }

    void InHit() 
    {
        if (HP >= 0)
        {
            HP--;
        }
        else
        {
            switch (Name)
            {
                case ("Small" or "Small(Clone)"):
                    ScoreManager.score += 7;
                    break;
                case ("Medium" or "Medium(Clone)"):
                    ScoreManager.score += 12;
                    break;
                case ("Large" or "Large(Clone)"):
                    ScoreManager.score += 30;
                    break;
            }
            Destroy(this.gameObject);
        }
    }
    
}
