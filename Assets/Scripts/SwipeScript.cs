using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeScript : MonoBehaviour
{
    Vector2 startPos, endPos, direction;
    float touchTimeStart, touchTimeFinish, timeInterval;

    [SerializeField] float throwForceInXandY = 10f;

    Rigidbody rb;
    Vector3 originalPos;
    int flag = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
        originalPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == 0)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                touchTimeStart = Time.time;
                startPos = Input.GetTouch(0).position;
            }
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                touchTimeFinish = Time.time;
                timeInterval = touchTimeFinish - touchTimeStart;
                endPos = Input.GetTouch(0).position;
                direction = startPos-endPos;
                rb.AddForce(-direction.x*throwForceInXandY, 0, -direction.y*throwForceInXandY, ForceMode.Force);
                flag = 1;
            }
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "walls" || rb.velocity.magnitude < 0.5f)
        {
            gameObject.transform.position = originalPos;
            flag = 0;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            if (PinsCollision.repeat != 0)
                PinsCollision.repeat -= 1;
            PinsDisable.Disable();
        }
    }
}
