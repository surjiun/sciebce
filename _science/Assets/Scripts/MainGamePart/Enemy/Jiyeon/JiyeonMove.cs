using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class JiyeonMove : MonoBehaviour
{
    GameObject target;
    NavMeshAgent nav;

    public static int Phase = 0;

    float time = 0.0f;
    float delayTime = 0.0f;
    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("target");
    }

    void FixedUpdate()
    {
        if (Phase == 0)
        {
            delayTime = 0;
            nav.speed = 0.0f;
        }
        if (Phase == 1)
        {
            delayTime = 3;
            nav.speed = 3.5f;
        }
        else if (Phase == 2)
        {
            delayTime = 2.75f;
            nav.speed = 3.75f;
        }
        else if (Phase == 3)
        {
            delayTime = 2.5f;
            nav.speed = 3.75f;
        }
        else if (Phase == 4)
        {
            delayTime = 2.5f;
            nav.speed = 4.0f;
        }
        else if (Phase == 5)
        {
            delayTime = 2.25f;
            nav.speed = 4.0f;
        }

        if (time <= delayTime)
        {
            time += Time.deltaTime;
            if(time + 0.1f >= delayTime)
            {
                findtarget();
            }
        }
        else
        {
            time = 0.0f;
        }
    }
    void findtarget()
    {
        nav.SetDestination(target.transform.position);
    }
   
} 
