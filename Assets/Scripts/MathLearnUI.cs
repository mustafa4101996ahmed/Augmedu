using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathLearnUI : MonoBehaviour {

    public Button startButton;
    public Button playButton;
    public Button nextQuestion;
    public Button levelSelection;
    public Button mathQuizButton;
    public MathLearnController mathAnimation;
    private int stepsCompleted = 0;

    public GameObject Step1Correct;
    public GameObject Step2Correct;
    public GameObject Step3Correct;
    public GameObject Step4Correct;

    public GameObject Step1Wrong;
    public GameObject Step2Wrong;
    public GameObject Step3Wrong;
    public GameObject Step4Wrong;

    public GameObject Step1Null;
    public GameObject Step2Null;
    public GameObject Step3Null;
    public GameObject Step4Null;

    

    void Start()
    {
        SetInitReferences();
    }

    public void StartClass () 
	{
        startButton.gameObject.SetActive(false);
        playButton.gameObject.SetActive(true);
        levelSelection.interactable = false;
        StartCoroutine(mathAnimation.StepOne());
        //while (mathAnimation.right == false)
         //   playButton.interactable = false;
        stepsCompleted = 1;
        Step1Correct.SetActive(true);
        Step1Null.SetActive(false);
        playButton.interactable = true;
        mathQuizButton.interactable = false;
	}

    public void PressPlay ()
    {
        if(stepsCompleted == 1)
        {
            playButton.interactable = false;
            StartCoroutine(mathAnimation.StepTwo());
            stepsCompleted = 2;
            Step2Correct.SetActive(true);
            Step2Null.SetActive(false);
            playButton.interactable = true;
        }

        else if (stepsCompleted == 2)
        {
            playButton.interactable = false;
            StartCoroutine(mathAnimation.StepThree());
            stepsCompleted = 3;
            Step3Correct.SetActive(true);
            Step3Null.SetActive(false);
            playButton.interactable = true;
        }

        else if (stepsCompleted == 3)
        {
            playButton.interactable = false;
            StartCoroutine(mathAnimation.StepFour());
            stepsCompleted = 4;
            Step4Correct.SetActive(true);
            Step4Null.SetActive(false);
            playButton.gameObject.SetActive(false);
            nextQuestion.gameObject.SetActive(true);
        }
    }

    public void resetMath ()
    {
        SetInitReferences();
        mathAnimation.resetAnimation();
        levelSelection.interactable = true;
    }
	void Update () 
	{
		
	}

    void SetInitReferences()
    {
        stepsCompleted = 0;

        nextQuestion.gameObject.SetActive(false);
        startButton.gameObject.SetActive(true);
        playButton.gameObject.SetActive(false);
        playButton.interactable = false;
        mathQuizButton.interactable = true;

        Step1Null.SetActive(true);
        Step2Null.SetActive(true);
        Step3Null.SetActive(true);
        Step4Null.SetActive(true);

        Step1Correct.SetActive(false);
        Step2Correct.SetActive(false);
        Step3Correct.SetActive(false);
        Step4Correct.SetActive(false);

        Step1Wrong.SetActive(false);
        Step2Wrong.SetActive(false);
        Step3Wrong.SetActive(false);
        Step4Wrong.SetActive(false);
    }
}


