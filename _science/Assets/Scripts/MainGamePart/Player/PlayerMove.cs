using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Slider RunGage;
    float runGage = 100.0f;
    int Speed = 5;

    void Update()
    {
        RunGage.value = runGage;

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
            runGage -= 7 * Time.deltaTime;
        }
        else
        {
            Speed = 5;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Teacher")
        {
            SceneManager.LoadScene("DeadScene");
        }
       
    }
}
