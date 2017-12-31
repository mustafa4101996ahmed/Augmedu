using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TracingQuizScript : MonoBehaviour
{
    public int score = 0;

    public bool collider0 = false;
    public bool collider1 = false;
    public bool collider2 = false;
    public bool collider3 = false;
    public bool collider4 = false;
    public bool collider5 = false;
    public bool collider6 = false;
    public bool collider7 = false;
    public bool collider8 = false;
    public bool collider9 = false;

    public ProgressBar progress0;
    public ProgressBar progress1;
    public ProgressBar progress2;
    public ProgressBar progress3;
    public ProgressBar progress4;
    public ProgressBar progress5;
    public ProgressBar progress6;
    public ProgressBar progress7;
    public ProgressBar progress8;
    public ProgressBar progress9;

    public TracingQuizUI currentNumber;

    void Start()
    {
        Reset();
    }

    public void CheckAnswer()
    {
        switch (currentNumber.currentNumber)
        {
            case 0:
                Debug.Log("Score: " + score);
                progress0.setPercentage(score*10);
                break;

            case 1:
                Debug.Log("Score: " + score);
                progress1.setPercentage(score*10);
                break;

            case 2:
                Debug.Log("Score: " + score);
                progress2.setPercentage(score*10);
                break;

            case 3:
                Debug.Log("Score: " + score);
                progress3.setPercentage(score*10);
                break;

            case 4:
                Debug.Log("Score: " + score);
                progress4.setPercentage(score*10);
                break;

            case 5:
                Debug.Log("Score: " + score);
                progress5.setPercentage(score*10);
                break;

            case 6:
                Debug.Log("Score: " + score);
                progress6.setPercentage(score*10);
                break;

            case 7:
                Debug.Log("Score: " + score);
                progress7.setPercentage(score*10);
                break;

            case 8:
                Debug.Log("Score: " + score);
                progress8.setPercentage(score*10);
                break;

            case 9:
                Debug.Log("Score: " + score);
                progress9.setPercentage(score*10);
                break;
        }
    }

    public void Reset()
    {
        collider0 = false;
        collider1 = false;
        collider2 = false;
        collider3 = false;
        collider4 = false;
        collider5 = false;
        collider6 = false;
        collider7 = false;
        collider8 = false;
        collider9 = false;
        score = 0;
    }
}


