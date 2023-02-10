using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class Visualizer : MonoBehaviour
{
    public GameObject source;
    public GameObject destination;
    public GameObject VizTool;
    float i = 1, j = 0,k=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void delayTime()
    {
        Instantiate(VizTool, transform.position = new Vector2(i + 0.5f, j + 0.5f), Quaternion.identity);
        j += 1;
        k += 1;
        i = (int)k/10+1;
        j=j%10;
        visualizePath();
    }


    public void visualizePath()
    {
        if (i != 30 && j != 10)
        {
            Invoke("delayTime", 0.05f);
        }
        /*    //source.transform.position = new Vector2(4, 4);
            //destination.transform.position = new Vector2(10, 10);
            for (float i = 4*//*source.transform.position.x*//*; i <10*//*destination.transform.position.x*//*; i = i + 1)
            {
                for (float j = 4*//*source.transform.position.y*//*; j < 10*//*destination.transform.position.y*//*; j = j + 1)
                {

                    Instantiate(VizTool, transform.position = new Vector2(i+0.5f, j+0.5f), Quaternion.identity);
                }
            }
        }*/
    }
  
}
