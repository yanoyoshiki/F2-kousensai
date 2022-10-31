using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowGoal : MonoBehaviour
{
    public Text GoalText;

    float goal = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (goal > 0)
        {
            GoalText.text = "GOAL!";
        }
    }

    public void goalcheck()
    {
        goal++;
    }

}
