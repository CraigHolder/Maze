using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject obj_player;
    public CharacterController c_control;
    public Vector3 vec3_checkpoint;

    // Start is called before the first frame update
    void Start()
    {
        vec3_checkpoint = new Vector3(48, 1, -48);
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

        c_control.Move(new Vector3(0, -2 * Time.deltaTime, 0));
    }
}
