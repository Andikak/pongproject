﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolaaku : MonoBehaviour
{
    public int speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-1,-1) * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.name=="Skanan" || other.collider.name=="Skiri"){
            GetComponent<Transform>().position = new Vector2(0,0);
        }
    }
}
