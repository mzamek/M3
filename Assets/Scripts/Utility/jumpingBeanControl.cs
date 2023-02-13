using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpingBeanControl : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody body;
    public float impulseForceMultiplier = 5f;
    public float impulseTorqueMultiplier = 5f;
    public ForceMode mode = ForceMode.Impulse;
    public bool isGrounded=true;
    public bool closeToJumpableGround;
    public float time;
    public float timeDelay=6f;
    private float nextDelay=1f;
    void Start()
    {
        body = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void FixedUpdate()
    {
        if (isGrounded || CharacterCommon.CheckGroundNear(this.transform.position, 45f, 0.85f, 0f, out closeToJumpableGround)) {
            if (time >= nextDelay) {
                float impulseForce = Random.Range(0.1f, 1f);
                //body.AddForce(Vector3.up * impulseForce * impulseForceMultiplier, mode);
                body.AddForce(new Vector3(Random.Range(-0.2f, 0.2f), Random.Range(0f, 1f), Random.Range(0.2f, 0.2f)) * impulseForce * impulseForceMultiplier, mode);
                body.AddTorque(new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(1f, 1f)) * impulseTorqueMultiplier);
                isGrounded = false;
                time = 0f;
                nextDelay = Random.Range(0.1f, 1f) * timeDelay;

            }
            else
            {
                time += Time.deltaTime;
            }
        }   
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.gameObject.tag == "ground")
        {

            isGrounded = true;

        }

    }
}
