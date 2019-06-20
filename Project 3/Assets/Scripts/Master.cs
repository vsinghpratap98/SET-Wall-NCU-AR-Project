using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{

    public GameObject[] marker;
    public GameObject[] maps;


    public void setMarker(string selectedMarker)
    {
        
            //  print("marker: " + selectedMarker);
            foreach (GameObject gameMark in marker)
            {
                if (gameMark.tag == selectedMarker)
                {
                    gameMark.SetActive(true);
                }
                else
                {
                    gameMark.SetActive(false);
                }
            }
        
        


    }
    public void setMap(string selectedMap)
    {
        
            foreach (GameObject gameMap in maps)
            {
                if (gameMap.tag == selectedMap)
                {
                    gameMap.SetActive(true);

                }
                else
                {
                    gameMap.SetActive(false);
                }
            }
        
       

    }

    public void ClearAll()
    {
        foreach (GameObject gameMap in maps)
        {

            gameMap.SetActive(false);

        }
        foreach (GameObject gameMark in marker)
        {


            gameMark.SetActive(true);



        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
