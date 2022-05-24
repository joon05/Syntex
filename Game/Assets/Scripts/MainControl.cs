using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControl : MonoBehaviour
{
    public List<int> items = new List<int>();
    public float hp;
    public float at;
    public float df;
    public bool pause;
   
    void Start()
    {
        pause = false;
    }

    
    void Update()
    {
        if (pause==false)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                Debug.Log("a");
                Time.timeScale = 0;
                pause = true;
            }
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.Tab))
            {
                Debug.Log("b");
                Time.timeScale = 1;
                pause = false;
            }
        }
    }
}
