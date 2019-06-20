using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDown : MonoBehaviour
{
    public GameObject marker, marker1, marker2;
    private GameObject storemarker;
    private int c=0;
        private int d=0;
                private int e=0;


    public void Switchoff(GameObject abc)
    {
        storemarker = abc;

    }
    
    // Update is called once per frame
    public void myfunc(int value)
    {
        Debug.Log(value);
        switch (value)
        {
            case 1:
                if (c == 0)
                {
                    Debug.Log("c==0");
                    marker.SetActive(true);
                    c++;
                    Debug.Log(c);
                    break;

                }
                else
                {
                    Debug.Log("c==1");
                    marker.SetActive(false);
                    c--;
                    Debug.Log(c);

                    break;

                }
            case 2:
                if (d == 0)
                {
                    Debug.Log("d==0");
                    marker1.SetActive(true);
                    d++;
                    Debug.Log(c);
                    break;

                }
                else
                {
                    Debug.Log("d==1");
                    marker1.SetActive(false);
                    d--;
                    Debug.Log(c);

                    break;

                }
                case 3:
                if (e == 0)
                {
                    Debug.Log("e==0");
                    marker2.SetActive(true);
                    e++;
                    Debug.Log(c);
                    break;

                }
                else
                {
                    Debug.Log("e==1");
                    marker2.SetActive(false);
                    e--;
                    Debug.Log(c);

                    break;

                }

        }

    }
}
