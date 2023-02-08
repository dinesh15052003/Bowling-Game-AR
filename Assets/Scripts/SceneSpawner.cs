using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    private PlaneIndicator placementIndicator;


    void Start()
    {
        placementIndicator = FindObjectOfType<PlaneIndicator>();
    }

    /*void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(objectToSpawn, 
                placementIndicator.transform.position, placementIndicator.transform.rotation);
           
        }
        
    }*/
    public void Activate() {

        GameObject obj = Instantiate(objectToSpawn,
                placementIndicator.transform.position, placementIndicator.transform.rotation);
        obj.transform.Rotate(0f, 180f, 0f);
        obj.gameObject.tag = "scene";

    }
}
