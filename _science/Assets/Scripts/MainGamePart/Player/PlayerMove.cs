using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /*public static Vector3 mos;
    //추적할 대상
    public Transform target;
    //카메라 회전 속도
    float xSpeed = 220.0f;
    float ySpeed = 100.0f;
    //카메라 초기 위치
    private float x = 0.0f;
    private float y = 0.0f;
    //y값 제한 (위 아래 제한)
    float yMinLimit = -20f;
    float yMaxLimit = 80f;
   
    //앵글의 최소,최대 제한
    float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }
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
            //앵글값 정하기(y값 제한)
            y = ClampAngle(y, yMinLimit, yMaxLimit);
            //카메라 위치 변화 계산
            Quaternion rotation = Quaternion.Euler(y, x, 0);
            Vector3 position = rotation * new Vector2(0, 0.9f) + target.position + new Vector3(0.0f, 0, 0.0f);
            transform.rotation = rotation;
            target.rotation = Quaternion.Euler(0, x, 0);
            transform.position = position;


            //마우스 좌표
            mos = Input.mousePosition;
        }//뚝배기 회전
    }*/
    void Update()
    {
            Vector3 pos = Input.mousePosition;
            pos.z = 10;
            Vector3 target = Camera.main.ScreenToWorldPoint(pos);
            print("target" + target);
            transform.LookAt(target);
    } 
}
