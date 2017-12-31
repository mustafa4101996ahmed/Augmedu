using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TracingLearnUI : MonoBehaviour {

    public GameObject NumbersList;
    public GameObject UserNumber;
    public int currentNumber;
    public TracingLearnController tracingAnimation;
    public TracingLearnScript tracingScript;
    public GameObject WritingPanel;
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
    public Button writingButton;

    void Start () 
	{
        UserNumber.SetActive(false);
        TracingCamera.enabled = false;
        SwipeManager.SetActive(false);
        HideAllPanels();
    }

    public void ChooseNumber0()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        writingButton.enabled = true;
        NumbersList.SetActive(false);
        currentNumber = 0;
        Panel0.SetActive(true);
        StartCoroutine(tracingAnimation.WriteOnBoard());
        UserNumber.SetActive(true);
        tracingScript.CharacterNumber.text = "0";;
    }

    public void ChooseNumber1 ()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        writingButton.enabled = true;
        NumbersList.SetActive(false);
        currentNumber = 1;
        Panel1.SetActive(true);
        StartCoroutine(tracingAnimation.WriteOnBoard());
        UserNumber.SetActive(true);
        tracingScript.CharacterNumber.text = "1";
    }

    public void ChooseNumber2()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        writingButton.enabled = true;
        NumbersList.SetActive(false);
        currentNumber = 2;
        Panel2.SetActive(true);
        StartCoroutine(tracingAnimation.WriteOnBoard());
        UserNumber.SetActive(true);
        tracingScript.CharacterNumber.text = "2";
    }

    public void ChooseNumber3()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        writingButton.enabled = true;
        NumbersList.SetActive(false);
        currentNumber = 3;
        Panel3.SetActive(true);
        StartCoroutine(tracingAnimation.WriteOnBoard());
        UserNumber.SetActive(true);
        tracingScript.CharacterNumber.text = "3";
    }

    public void ChooseNumber4()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        writingButton.enabled = true;
        NumbersList.SetActive(false);
        currentNumber = 4;
        Panel4.SetActive(true);
        StartCoroutine(tracingAnimation.WriteOnBoard());
        UserNumber.SetActive(true);
        tracingScript.CharacterNumber.text = "4";
    }

    public void ChooseNumber5()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        writingButton.enabled = true;
        NumbersList.SetActive(false);
        currentNumber = 5;
        Panel5.SetActive(true);
        StartCoroutine(tracingAnimation.WriteOnBoard());
        UserNumber.SetActive(true);
        tracingScript.CharacterNumber.text = "5";
    }

    public void ChooseNumber6()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        writingButton.enabled = true;
        NumbersList.SetActive(false);
        currentNumber = 6;
        Panel6.SetActive(true);
        StartCoroutine(tracingAnimation.WriteOnBoard());
        UserNumber.SetActive(true);
        tracingScript.CharacterNumber.text = "6";
    }

    public void ChooseNumber7()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        writingButton.enabled = true;
        NumbersList.SetActive(false);
        currentNumber = 7;
        Panel7.SetActive(true);
        StartCoroutine(tracingAnimation.WriteOnBoard());
        UserNumber.SetActive(true);
        tracingScript.CharacterNumber.text = "7";
    }

    public void ChooseNumber8()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        writingButton.enabled = true;
        NumbersList.SetActive(false);
        currentNumber = 8;
        Panel8.SetActive(true);
        StartCoroutine(tracingAnimation.WriteOnBoard());
        UserNumber.SetActive(true);
        tracingScript.CharacterNumber.text = "8";
    }

    public void ChooseNumber9()
    {
        swipeHandler.Reset();
        HideAllPanels();
        tracingScript.Reset();
        writingButton.enabled = true;
        NumbersList.SetActive(false);
        currentNumber = 9;
        Panel9.SetActive(true);
        StartCoroutine(tracingAnimation.WriteOnBoard());
        UserNumber.SetActive(true);
        tracingScript.CharacterNumber.text = "9";
    }

    public void UserWrites()
    {
        WritingPanel.SetActive(true);
        ARCamera.enabled = false;
        TracingCamera.enabled = true;
        SwipeManager.SetActive(true);
        writingButton.enabled = false;
        Debug.Log("Camera Switched to Tracing Camera");
        //SceneManager.LoadScene("8TracingAction");
    }

    public void Confirm ()
    {
        ARCamera.enabled = true;
        TracingCamera.enabled = false;
        WritingPanel.SetActive(false);
        SwipeManager.SetActive(false);
        Debug.Log("Camera Switched to AR Camera");
        tracingAnimation.ReturnToPosition();
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


