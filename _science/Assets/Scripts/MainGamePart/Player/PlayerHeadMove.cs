using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeadMove : MonoBehaviour
{
    public static Vector3 mos;
    //카메라 회전 속도
    float xSpeed = 220.0f;
    float ySpeed = 100.0f;
    //카메라 초기 위치
    private float x = 0.0f;
    private float y = 0.0f;
   
    void Start()
    {
        {
            Cursor.lockState = CursorLockMode.Locked; //커서 고정
            Vector3 angles = transform.eulerAngles;

            x = angles.y;
            y = angles.x;
        }//뚝배기 회전
        
    }
    void FixedUpdate()
    {
        {
            //카메라 회전속도 계산
            x += Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime;
            y -= Input.GetAxis("Mouse Y") * ySpeed * Time.deltaTime;
            //카메라 위치 변화 계산
            Quaternion rotation = Quaternion.Euler(y, x, 0);
            Vector3 position = gameObject.transform.position + new Vector3(0.0f, 0, 0.0f);
            transform.rotation = rotation;
            gameObject.transform.rotation = Quaternion.Euler(0, x, 0);
            transform.position = position;

            //마우스 좌표
            mos = Input.mousePosition;
        }//뚝배기 회전
    }
}
