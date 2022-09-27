using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

   int score =  0;

    // Start is called before the first frame update
    void Start()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeScore(int coinV)
    {
        score += coinV;
        Debug.Log(score); 
    }
}
