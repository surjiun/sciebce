using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    public int NoteNum;
    public GameObject Player;
    float cubeDistance;

    private GameObject target;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = GetClickedObject();
            cubeDistance = Vector3.Distance(Player.transform.position, gameObject.transform.position);
            if (target.Equals(gameObject) && cubeDistance <= 2)
            {
                Problems.Problem = NoteNum;
                Destroy(gameObject);
            }
        }
    }

    private GameObject GetClickedObject()
    {
        RaycastHit hit;
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (true == (Physics.Raycast(ray.origin, ray.direction, out hit)))
        {
            target = hit.collider.gameObject;
        }
        return target;
    }
}
