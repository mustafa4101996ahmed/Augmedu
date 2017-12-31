using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TracingLearnScript : MonoBehaviour {

    public Text CharacterNumber;

    public int score = 0;
    private int mark = 2;

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

    public GameObject Step0Correct;
    public GameObject Step1Correct;
    public GameObject Step2Correct;
    public GameObject Step3Correct;
    public GameObject Step4Correct;
    public GameObject Step5Correct;
    public GameObject Step6Correct;
    public GameObject Step7Correct;
    public GameObject Step8Correct;
    public GameObject Step9Correct;

    public GameObject Step0Wrong;
    public GameObject Step1Wrong;
    public GameObject Step2Wrong;
    public GameObject Step3Wrong;
    public GameObject Step4Wrong;
    public GameObject Step5Wrong;
    public GameObject Step6Wrong;
    public GameObject Step7Wrong;
    public GameObject Step8Wrong;
    public GameObject Step9Wrong;

    public GameObject Step0Null;
    public GameObject Step1Null;
    public GameObject Step2Null;
    public GameObject Step3Null;
    public GameObject Step4Null;
    public GameObject Step5Null;
    public GameObject Step6Null;
    public GameObject Step7Null;
    public GameObject Step8Null;
    public GameObject Step9Null;

    public TracingLearnUI currentNumber;

    void Start()
    {
        Reset();
    }

    public void CheckAnswer()
    {
        switch(currentNumber.currentNumber)
        {
            case 0:
                Step0Null.SetActive(false);
                Debug.Log("Score: " + score);
                if (score >= mark)
                {
                    Step0Correct.SetActive(true);
                }
                else if(score < mark)
                {
                    Step0Wrong.SetActive(true);
                }
                break;

            case 1:
                Step1Null.SetActive(false);
                Debug.Log("Score: " + score);
                if (score >= mark)
                {
                    Step1Correct.SetActive(true);
                }
                else if (score < mark)
                {
                    Step1Wrong.SetActive(true);
                }
                break;

            case 2:
                Step2Null.SetActive(false);
                Debug.Log("Score: " + score);
                if (score >= mark)
                {
                    Step2Correct.SetActive(true);
                }
                else if (score < mark)
                {
                    Step2Wrong.SetActive(true);
                }
                break;

            case 3:
                Step3Null.SetActive(false);
                Debug.Log("Score: " + score);
                if (score >= mark)
                {
                    Step3Correct.SetActive(true);
                }
                else if (score < mark)
                {
                    Step3Wrong.SetActive(true);
                }
                break;

            case 4:
                Step4Null.SetActive(false);
                Debug.Log("Score: " + score);
                if (score >= mark)
                {
                    Step4Correct.SetActive(true);
                }
                else if (score < mark)
                {
                    Step4Wrong.SetActive(true);
                }
                break;

            case 5:
                Step5Null.SetActive(false);
                Debug.Log("Score: " + score);
                if (score >= mark)
                {
                    Step5Correct.SetActive(true);
                }
                else if (score < mark)
                {
                    Step5Wrong.SetActive(true);
                }
                break;

            case 6:
                Step6Null.SetActive(false);
                Debug.Log("Score: " + score);
                if (score >= mark)
                {
                    Step6Correct.SetActive(true);
                }
                else if (score < mark)
                {
                    Step6Wrong.SetActive(true);
                }
                break;

            case 7:
                Step7Null.SetActive(false);
                Debug.Log("Score: " + score);
                if (score >= mark)
                {
                    Step7Correct.SetActive(true);
                }
                else if (score < mark)
                {
                    Step7Wrong.SetActive(true);
                }
                break;

            case 8:
                Step8Null.SetActive(false);
                Debug.Log("Score: " + score);
                if (score >= mark)
                {
                    Step8Correct.SetActive(true);
                }
                else if (score < mark)
                {
                    Step8Wrong.SetActive(true);
                }
                break;

            case 9:
                Step9Null.SetActive(false);
                Debug.Log("Score: " + score);
                if (score >= mark)
                {
                    Step9Correct.SetActive(true);
                }
                else if (score < mark)
                {
                    Step9Wrong.SetActive(true);
                }
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


