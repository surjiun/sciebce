using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class test : MonoBehaviour
{
    GameObject target;
    NavMeshAgent nav;
    public float time;
    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("target");
    }

    void FixedUpdate()
    {
        findtarget();
    }
    void findtarget()
    {
        nav.SetDestination(target.transform.position);
    }
   
} 
