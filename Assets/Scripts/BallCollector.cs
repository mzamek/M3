using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollector : MonoBehaviour
{
    public Boolean hasBall = false;
    // Start is called before the first frame update
    public void ReceiveBall() 
    { 
        hasBall = true; 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
