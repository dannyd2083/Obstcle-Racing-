// ﻿using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class PlayerCollsion : MonoBehaviour
{
    // // Start is called before the first frame update
    // void Start()
    // {
    //
    // }
    //
    // // Update is called once per frame
    // void Update()
    // {
    //
    // }
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo){
      if(collisionInfo.collider.tag == "Obstacle")
      {
        movement.enabled = false;
        FindObjectOfType<GameManager>().EndGame();
      }
    }

    void OnTriggerEnter(Collider collider){
      if(collider.tag == "coin")
      {
        Score.score++;
        Destroy(collider.gameObject);
      }
    }


}
