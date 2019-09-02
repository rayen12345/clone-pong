using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 15;
    public string axis;
    void FixedUpdate()
    {

        float v = Input.GetAxisRaw(axis) * speed;

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v);

      
    }
}


