using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Specilaisationclick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject s1, s2, s3, s4, s5;
    public void DataScience(){
                    s1.SetActive(true);
                    s2.SetActive(false);
                    s3.SetActive(false);
                    s4.SetActive(false);
                    s5.SetActive(false);
    }
    public void CyberOn(){
                    s1.SetActive(false);
                    s2.SetActive(true);
                    s3.SetActive(false);
                    s4.SetActive(false);
                    s5.SetActive(false);
    }
    public void IoTOn(){
                    s1.SetActive(false);
                    s2.SetActive(false);
                    s3.SetActive(true);
                    s4.SetActive(false);
                    s5.SetActive(false);
    }
    public void FullStackOn(){
                    s1.SetActive(false);
                    s2.SetActive(false);
                    s3.SetActive(false);
                    s4.SetActive(true);
                    s5.SetActive(false);
    }
    public void GameTechOn(){
                    s1.SetActive(false);
                    s2.SetActive(false);
                    s3.SetActive(false);
                    s4.SetActive(false);
                    s5.SetActive(true);
    }
}
