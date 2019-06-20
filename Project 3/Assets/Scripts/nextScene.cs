using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextScene : MonoBehaviour
{
    public GameObject s1, s2;
    public void OnMouseDown()
    {
        if (transform.tag == "1")
        {
            s1.SetActive(false);
            s2.SetActive(true);
        }
        else if (transform.tag == "2")
        {
            s1.SetActive(false);
            s2.SetActive(true);
        }
        else if (transform.tag == "3")
        {
            s1.SetActive(false);
            s2.SetActive(true);
        }
        else if (transform.tag == "4")
        {
            s1.SetActive(false);
            s2.SetActive(true);
        }
        else if (transform.tag == "5")
        {
            s1.SetActive(false);
            s2.SetActive(true);
        }
        else if (transform.tag == "6")
        {
            s2.SetActive(false);
            s1.SetActive(true);
        }
        else if (transform.tag == "7")
        {
            s2.SetActive(false);
            s1.SetActive(true);
        }
        else if (transform.tag == "8")
        {
            s2.SetActive(false);
            s1.SetActive(true);
        }
        else if (transform.tag == "9")
        {
            s2.SetActive(false);
            s1.SetActive(true);
        }
        else if (transform.tag == "10")
        {
            s2.SetActive(false);
            s1.SetActive(true);
        }
    }
}
