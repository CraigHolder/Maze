using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject obj_player;
    public CharacterController c_control;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            c_control.Move(new Vector3(0, 0, 10 * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            c_control.Move(new Vector3(0, 0, -10 * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            c_control.Move(new Vector3(10 * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            c_control.Move(new Vector3(-10 * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.Space))
        {
            c_control.Move(new Vector3(0, 10 * Time.deltaTime, 0));
        }

        if(c_control.isGrounded == false)
        {
            c_control.Move(new Vector3(0, -1 * Time.deltaTime, 0));
        }
    }
}
