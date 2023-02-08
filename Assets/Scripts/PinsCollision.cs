using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinsCollision : MonoBehaviour
{
    public static int repeat = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "pins" || other.gameObject.tag == "ball" || other.gameObject.tag == "fallen")
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.useGravity = true;
            ScoreCounter.score += 10*repeat;
            transform.gameObject.tag = "fallen";
        }
    }
}
