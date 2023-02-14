using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider c)
    {
        if (c.attachedRigidbody != null)
        {
            BallCollector bc = c.attachedRigidbody.gameObject.GetComponent<BallCollector>();
            //Debug.Log("OnTriggerEnter: attachedRigidbody");
            if (bc != null)
            {
                //Debug.Log("OnTriggerEnter: bc !=null");
                EventManager.TriggerEvent<BombBounceEvent, Vector3>(c.transform.position);
                bc.ReceiveBall();
                Destroy(this.gameObject);
            }
        }

    }
}
