using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timePauseScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            if (Time.timeScale==0)
            {
                Time.timeScale = 1f;
            } else
            {
                Time.timeScale = 0f;
            }
        }
    }
}
