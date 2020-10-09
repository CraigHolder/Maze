using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    Vector3 vec3_checkpoint;
    public PlayerMovement s_playerscript;

    void Start()
    {
        vec3_checkpoint = transform.position;
    }
    void OnTriggerEnter(Collider collision)
    {
        s_playerscript.vec3_checkpoint = vec3_checkpoint;
    }
}
