using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : MonoBehaviour
{

      void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag == "Player"){
          Debug.Log("enter the dashTrigger");
          collider.gameObject.GetComponent<PlayerMovement>().rb.AddForce(transform.up*500);
        }
      }
}
