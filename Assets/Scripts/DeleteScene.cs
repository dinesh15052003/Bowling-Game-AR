using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeleteScene : MonoBehaviour
{
    [SerializeField] private GameObject score,img; 
    TMP_Text t;
    // Start is called before the first frame update
    void Start()
    {
        t = score.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PinsDisable.delete == 1)
        {
            img.SetActive(true);
            PinsDisable.delete = 0;
            t.text = ScoreCounter.finalscore.ToString();
        }
    }
    public static void Delete()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("scene");
        Destroy(obj);
        ScoreCounter.score = 0;
        PinsCollision.repeat = 4;
    }
}
