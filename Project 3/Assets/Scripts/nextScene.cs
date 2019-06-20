using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class nextScene : MonoBehaviour
{
    public Master master;

    int map;
    int value;
    int clickCount = 0;
    public void OnMouseDown()
    {
        clickCount++;
        value = Int32.Parse(transform.tag);
        map = value + 5;
        print("click value : " + value);
        if (clickCount % 2 == 0)
        {
            master.ClearAll();

        }
        else
        {
            master.setMarker(value.ToString());
            master.setMap(map.ToString());
        }
        

    }
}
