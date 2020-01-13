using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaveItemList : MonoBehaviour
{
    int selectItem = 0;
    public static int[] ItemList = new int[3];

    public GameObject Soda;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Tab))
        {
            selectItem++;
            {
                if(selectItem == 3)
                {
                    selectItem = 0;
                }
            }
        }

        if(Input.GetKey(KeyCode.Space))
        {
            if(ItemList[selectItem] == 1)
            {
    
            }
            else if(ItemList[selectItem] == 2)
            {

            }
        }
    }
}
