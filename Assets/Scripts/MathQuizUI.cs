using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathQuizUI : MonoBehaviour {

    public Button confirmButton;
    public Button nextQuestion;
    public Button mathLearnButton;
    public MathQuizController mathAnimation;
    public MathQuizScript quizDetails;
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

    private bool step1 = false; // Num1Right + Num2Right
    private bool step2 = false; // Carry
    private bool step3 = false; // Num1Left + Num2Left
    private bool step4 = false; // 3rd Digit

    private int totalMarks = 0; // Marks For Question
    private int subjectMarks = 0; // Marks for Subject
    private int clickCounter = 0;
    private int questionNumber = 0; // Count number of questions completed. 3 questions per difficulty
    private int Level1score = 0;
    private int Level2score = 0;
    private int Level3score = 0;

    public GameObject Slash;
    public GameObject OutofNumber;

    public GameObject Number0;
    public GameObject Number1;
    public GameObject Number2;
    public GameObject Number3;
    public GameObject Number4;

    public Text UIscore1;
    public Text UIscore3;
    public Text UIscore2;
    public Text UItotal;

    public GameObject ScoreSheet;

    void Start()
    {
        SetInitReferences();
    }

    void Update()
    {
        if (quizDetails.inputRight.text != "" && quizDetails.inputCarry.text != "" && quizDetails.inputMid.text != "" && quizDetails.inputLeft.text != "")
        {
            if (clickCounter > 0)
                confirmButton.interactable = false;
            else if (clickCounter == 0)
                confirmButton.interactable = true;
        }
    }

    public void PressConfirm()
    {
        int rightUser = int.Parse(quizDetails.inputRight.text);   // We Must Parse the Data before using (string to int)
        int carryUser = int.Parse(quizDetails.inputCarry.text);   // We Must Parse the Data before using (string to int)
        int midUser = int.Parse(quizDetails.inputMid.text);     // We Must Parse the Data before using (string to int)
        int leftUser = int.Parse(quizDetails.inputLeft.text);    // We Must Parse the Data before using (string to int)

        if (rightUser == quizDetails.rightAnswer) // Step 1 Check
        {
            step1 = true;
            Step1Correct.SetActive(true);
            Step1Null.SetActive(false);
            totalMarks++;
        }
        else
        {
            step1 = false;
            Step1Wrong.SetActive(true);
            Step1Null.SetActive(false);
        }

        if (carryUser == quizDetails.carryAnswer) // Step 2 Check
        {
            step2 = true;
            Step2Correct.SetActive(true);
            Step2Null.SetActive(false);
            totalMarks++;
        }
        else
        {
            step2 = false;
            Step2Wrong.SetActive(true);
            Step2Null.SetActive(false);
        }

        if (midUser == quizDetails.midAnswer) // Step 3 Check
        {
            step3 = true;
            Step3Correct.SetActive(true);
            Step3Null.SetActive(false);
            totalMarks++;
        }
        else
        {
            step3 = false;
            Step3Wrong.SetActive(true);
            Step3Null.SetActive(false);
        }

        if (leftUser == quizDetails.leftAnswer) // Step 4 Check
        {
            step4 = true;
            Step4Correct.SetActive(true);
            Step4Null.SetActive(false);
            totalMarks++;
        }
        else
        {
            step4 = false;
            Step4Wrong.SetActive(true);
            Step4Null.SetActive(false);
        }

        DisplayScore();
        clickCounter++;
        nextQuestion.gameObject.SetActive(true);

        if (quizDetails.setDifficulty == 1)
        {
            Level1score += totalMarks;
            UIscore1.text = Level1score.ToString();
        }
        if (quizDetails.setDifficulty == 2)
        {
            Level2score += totalMarks;
            UIscore2.text = Level2score.ToString();
        }
        if (quizDetails.setDifficulty == 3)
        {
            Level3score += totalMarks;
            UIscore3.text = Level3score.ToString();
        }

        subjectMarks += totalMarks;
        questionNumber++;

        if (questionNumber == 3)
        {
            nextQuestion.interactable = false;
            confirmButton.interactable = false;
            if (subjectMarks >= 9) //Proceed to next level
            {
                Debug.Log("Score is greater than 9");
                if (quizDetails.setDifficulty == 3)
                {
                    // Write total to database
                    confirmButton.gameObject.SetActive(false);
                    nextQuestion.gameObject.SetActive(false);
                    mathLearnButton.gameObject.SetActive(false);
                    UItotal.text = Level1score.ToString() + Level2score.ToString() + Level3score.ToString();
                    ScoreSheet.SetActive(true);
                }
                else if (quizDetails.setDifficulty == 1 || quizDetails.setDifficulty == 2)
                {
                    nextQuestion.interactable = true;
                    quizDetails.setDifficulty++;
                    questionNumber = 1;
                    Debug.Log("Next Level");
                }
            }
            else if (subjectMarks < 9)
            {
                Debug.Log("Score is less than 9");
                mathLearnButton.gameObject.SetActive(true);
            }
        }
    }

    public void NextQuestion()
    {
        SetInitReferences();
        quizDetails.NewQuestion();
    }

    void DisplayScore()
    {
        Slash.SetActive(true);
        OutofNumber.SetActive(true);

        if (totalMarks == 0)
        {
            Number0.SetActive(true);
            mathAnimation.ScoreZero();

        }
        else if (totalMarks == 1)
        {
            Number1.SetActive(true);
            mathAnimation.ScoreOne();
        }
        else if (totalMarks == 2)
        {
            Number2.SetActive(true);
            mathAnimation.ScoreTwo();
        }
        else if (totalMarks == 3)
        {
            Number3.SetActive(true);
            mathAnimation.ScoreThree();
        }
        else if (totalMarks == 4)
        {
            Number4.SetActive(true);
            mathAnimation.ScoreFour();
            //StartCoroutine(mathAnimation.ScoreFour());
        }
    }

    void SetInitReferences()
    {
        mathAnimation.ScoreTwo();
        totalMarks = 0;
        stepsCompleted = 0;
        clickCounter = 0;

        nextQuestion.gameObject.SetActive(false);
        confirmButton.interactable = false;
        mathLearnButton.gameObject.SetActive(false);
        ScoreSheet.SetActive(false);

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

        Number0.SetActive(false);
        Number1.SetActive(false);
        Number2.SetActive(false);
        Number3.SetActive(false);
        Number4.SetActive(false);
        Slash.SetActive(false);
        OutofNumber.SetActive(false);
    }
}


