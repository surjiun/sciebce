using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float runGage = 100.0f;
    int Speed = 5;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.LeftShift) && runGage > 0)
        {
            Speed = 8;
            runGage -= 2 * Time.deltaTime;
        }         
        else
        {
            Speed = 5;
            runGage +=  2 * Time.deltaTime;
        }
            
    }
}
