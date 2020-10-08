using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    public GameObject obj_player;
    CharacterController c_controller;

    void Start()
    {
        c_controller = obj_player.GetComponent<CharacterController>();
    }

    void OnTriggerEnter(Collider collision)
    {
        c_controller.enabled = false;
        obj_player.transform.position = new Vector3(0,0,0);
        c_controller.enabled = true;
    }
    
}
