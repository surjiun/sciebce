using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    public GameObject Player;
    float cubeDistance;

    private bool isOpen = false;
    private GameObject target;
    public new Animation animation;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = GetClickedObject();
            cubeDistance = Vector3.Distance(Player.transform.position, gameObject.transform.position);
            if (target.Equals(gameObject) && isOpen != true && cubeDistance <= 2 && Problems.Notes == 5)
            {
                SceneManager.LoadScene("MainGameScene");
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
