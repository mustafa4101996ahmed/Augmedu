using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathLearnController : MonoBehaviour {

    private Animator anim;
    private Animator mathAnim;
    private Animation animTest;
    int currentResult = 0;
    public MathLearnScript resultCheck;
    public Canvas MathCanvas;
    public MathLearnScript answers;
    public bool right = false, carry = false, mid = false, left = false;

    IEnumerator Start () 
	{
        GetComponent<Animator>().Play("breathing_idle", -1, 0.0f);
        yield return new WaitForSeconds(4); // Character Speaks to user first
    }

    public IEnumerator StepOne ()
    {
        GetComponent<Animator>().Play("MoveToBoard", -1, 0.0f); // Moves into writing position
        //GetComponent<Animator>().SetTrigger("AllowMove");
        Debug.Log("Completed MoveToBoard");

        MathCanvas.GetComponent<Animator>().Play("MoveRight", -1, 0.0f);
        Debug.Log("Completed Move Right");

        Debug.Log("Checking MoveRight");
        yield return StartCoroutine(writeNumber(1));
        Debug.Log("Completed write Right");

        yield return new WaitForSeconds(4); // Character Speaks to user first
        answers.rightResult.gameObject.SetActive(true);
        right = true;
    }

    public IEnumerator StepTwo ()
    {
        MathCanvas.GetComponent<Animator>().Play("MoveCarry", -1, 0.0f);

        Debug.Log("Checking MoveCarry");
        yield return StartCoroutine(writeNumber(2));
        Debug.Log("Completed write Carry");

        yield return new WaitForSeconds(4); // Character Speaks to user first
        answers.carryResult.gameObject.SetActive(true);
        carry = true;
    }

    public IEnumerator StepThree ()
    {
        MathCanvas.GetComponent<Animator>().Play("MoveMid", -1, 0.0f);

        Debug.Log("Checking MoveMid");
        yield return StartCoroutine(writeNumber(3));
        Debug.Log("Completed write Mid");

        yield return new WaitForSeconds(4); // Character Speaks to user first
        answers.midResult.gameObject.SetActive(true);
        mid = true;
    }

    public IEnumerator StepFour ()
    {
        MathCanvas.GetComponent<Animator>().Play("MoveLeft", -1, 0.0f);

        Debug.Log("Checking MoveLeft");
        yield return StartCoroutine(writeNumber(4));
        Debug.Log("Completed write Left");

        yield return new WaitForSeconds(4); // Character Speaks to user first
        answers.leftResult.gameObject.SetActive(true);
        left = true;
    }

    public void resetAnimation ()
    {
        MathCanvas.GetComponent<Animator>().Play("ReturnToStart", -1, 0.0f);
        GetComponent<Animator>().Play("ReturnFromBoard", -1, 0.0f); // Moves into writing position
        Debug.Log("Completed ReturnFromBoard");
    }

    void Update()
    {

    }

    IEnumerator writeNumber(int number)
    {
        Debug.Log("writeNumber: " + number + " has begun!");
        resultCheck = GameObject.Find("MathCanvas").GetComponent<MathLearnScript>();

        if (number == 1)
            currentResult = resultCheck.rightAnswer;
        else if (number == 2)
            currentResult = resultCheck.carryAnswer;
        else if (number == 3)
            currentResult = resultCheck.midAnswer;
        else if (number == 4)
            currentResult = resultCheck.leftAnswer;

        if (currentResult == 0)
        {
            GetComponent<Animator>().Play("0", -1, 0.0f);
            Debug.Log("Drawing 0");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("0"))
            {
                yield return null;
            }
        }
        else if (currentResult == 1)
        {
            GetComponent<Animator>().Play("1", -1, 0.0f);
            Debug.Log("Drawing 1");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("1"))
            {
                yield return null;
            }
        }
        else if (currentResult == 2)
        {
            GetComponent<Animator>().Play("2", -1, 0.0f);
            Debug.Log("Drawing 2");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("2"))
            {
                yield return null;
            }
        }
        else if (currentResult == 3)
        {
            GetComponent<Animator>().Play("3", -1, 0.0f);
            Debug.Log("Drawing 3");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("3"))
            {
                yield return null;
            }
        }
        else if (currentResult == 4)
        {
            GetComponent<Animator>().Play("4", -1, 0.0f);
            Debug.Log("Drawing 4");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("4"))
            {
                yield return null;
            }
        }
        else if (currentResult == 5)
        {
            GetComponent<Animator>().Play("5", -1, 0.0f);
            Debug.Log("Drawing 5");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("5"))
            {
                yield return null;
            }
        }
        else if (currentResult == 6)
        {
            GetComponent<Animator>().Play("6", -1, 0.0f);
            Debug.Log("Drawing 6");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("6"))
            {
                yield return null;
            }
        }
        else if (currentResult == 7)
        {
            GetComponent<Animator>().Play("7", -1, 0.0f);
            Debug.Log("Drawing 7");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("7"))
            {
                yield return null;
            }
        }
        else if (currentResult == 8)
        {
            GetComponent<Animator>().Play("8", -1, 0.0f);
            Debug.Log("Drawing 8");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("8"))
            {
                yield return null;
            }
        }
        else if (currentResult == 9)
        {
            GetComponent<Animator>().Play("9", -1, 0.0f);
            Debug.Log("Drawing 9");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("9"))
            {
                yield return null;
            }
        }
    }
}


