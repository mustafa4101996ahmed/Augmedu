using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TracingQuizUI : MonoBehaviour
{
    public TracingQuizController tracingAnimation;
    public TracingQuizScript tracingScript;

    public GameObject Panel0;
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;
    public GameObject Panel5;
    public GameObject Panel6;
    public GameObject Panel7;
    public GameObject Panel8;
    public GameObject Panel9;

    public Camera ARCamera;
    public Camera TracingCamera;
    public GameObject SwipeManager;
    public SwipeTrail swipeHandler;
    public GameObject writingPanel;
    public Button writingButton;
    public Text task;

    public int currentNumber;

    void Start()
    {
        writingButton.enabled = true;
        writingPanel.SetActive(false);
        TracingCamera.enabled = false;
        SwipeManager.SetActive(false);
        HideAllPanels();
        nextQuestion();
    }

    public void ChooseNumber0()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        currentNumber = 0;
        Panel0.SetActive(true);
        task.text = "Draw 0";
    }

    public void ChooseNumber1()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        currentNumber = 1;
        Panel1.SetActive(true);
        task.text = "Draw 1";
    }

    public void ChooseNumber2()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        currentNumber = 2;
        Panel2.SetActive(true);
        task.text = "Draw 2";
    }

    public void ChooseNumber3()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();;
        currentNumber = 3;
        Panel3.SetActive(true);
        task.text = "Draw 3";
    }

    public void ChooseNumber4()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        currentNumber = 4;
        Panel4.SetActive(true);
        task.text = "Draw 4";
    }

    public void ChooseNumber5()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        currentNumber = 5;
        Panel5.SetActive(true);
        task.text = "Draw 5";
    }

    public void ChooseNumber6()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        currentNumber = 6;
        Panel6.SetActive(true);
        task.text = "Draw 6";
    }

    public void ChooseNumber7()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        currentNumber = 7;
        Panel7.SetActive(true);
        task.text = "Draw 7";
    }

    public void ChooseNumber8()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        currentNumber = 8;
        Panel8.SetActive(true);
        task.text = "Draw 8";
    }

    public void ChooseNumber9()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        currentNumber = 9;
        Panel9.SetActive(true);
        task.text = "Draw 9";
    }

    public void UserWrites()
    {
        writingButton.enabled = false;
        writingPanel.SetActive(true);
        ARCamera.enabled = false;
        TracingCamera.enabled = true;
        SwipeManager.SetActive(true);
        Debug.Log("Camera Switched to Tracing Camera");
        //SceneManager.LoadScene("8TracingAction");
    }

    public void nextQuestion()
    {
        switch (currentNumber)
        {
            case 0:
                ChooseNumber0();
                break;
            case 1:
                ChooseNumber1();
                break;
            case 2:
                ChooseNumber2();
                break;
            case 3:
                ChooseNumber3();
                break;
            case 4:
                ChooseNumber4();
                break;
            case 5:
                ChooseNumber5();
                break;
            case 6:
                ChooseNumber6();
                break;
            case 7:
                ChooseNumber7();
                break;
            case 8:
                ChooseNumber8();
                break;
            case 9:
                ChooseNumber9();
                break;
        }
    }

    public void Confirm()
    {
        tracingScript.CheckAnswer();
        ARCamera.enabled = true;
        TracingCamera.enabled = false;
        SwipeManager.SetActive(false);
        Debug.Log("Camera Switched to AR Camera");
        writingPanel.SetActive(false);
        currentNumber++;
        nextQuestion();
    }


    public void HideAllPanels()
    {
        Panel0.SetActive(false);
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel7.SetActive(false);
        Panel8.SetActive(false);
        Panel9.SetActive(false);
    }
}


