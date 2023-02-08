using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PinsDisable : MonoBehaviour
{
    public static int delete = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int count=0;
        for (int i = 0; i<transform.childCount; i++)
        {
            if (transform.GetChild(i).gameObject.activeSelf)
            {
                count+=1;
                break;
            }
        }
        if (count == 0)
        {
            ScoreCounter.finalscore = ScoreCounter.score;
            delete = 1;
            DeleteScene.Delete();
            ScoreCounter.score = 0;
            PinsCollision.repeat = 4;
        }
    }

    public static void Disable()
    {
        GameObject[] pins = GameObject.FindGameObjectsWithTag("fallen");
        foreach(GameObject i in pins)
        {
            i.SetActive(false);
        }
    }
}
