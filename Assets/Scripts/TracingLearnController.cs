using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracingLearnController : MonoBehaviour
{

    private Animator anim;
    public Canvas TracingCanvas;
    public TracingLearnUI Number;

    IEnumerator Start()
    {
        GetComponent<Animator>().Play("breathing_idle", -1, 0.0f);
        yield return new WaitForSeconds(1); // Character Speaks to user first
    }

    public IEnumerator WriteOnBoard()
    {
        GetComponent<Animator>().Play("MoveToBoard", -1, 0.0f); // Moves into writing position
        Debug.Log("Completed MoveToBoard");

        Debug.Log("Checking MoveRight");
        int characterNumber = Number.currentNumber;
        yield return StartCoroutine(writeNumber(characterNumber));
        Debug.Log("Completed write Right");

        //yield return new WaitForSeconds(4); // Character Speaks to user first
        //Number.UserNumber.SetActive(true);
    }

    public void ReturnToPosition()
    {
        GetComponent<Animator>().Play("ReturnFromBoard", -1, 0.0f); // Moves into writing position
        Debug.Log("Completed ReturnBack");
    }

    IEnumerator writeNumber(int number)
    {
        Debug.Log("writeNumber: " + number + " has begun!");


        if (number == 0)
        {
            GetComponent<Animator>().Play("0", -1, 0.0f);
            Debug.Log("Drawing 0");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("0"))
            {
                yield return null;
            }
        }
        else if (number == 1)
        {
            GetComponent<Animator>().Play("1", -1, 0.0f);
            Debug.Log("Drawing 1");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("1"))
            {
                yield return null;
            }
        }
        else if (number == 2)
        {
            GetComponent<Animator>().Play("2", -1, 0.0f);
            Debug.Log("Drawing 2");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("2"))
            {
                yield return null;
            }
        }
        else if (number == 3)
        {
            GetComponent<Animator>().Play("3", -1, 0.0f);
            Debug.Log("Drawing 3");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("3"))
            {
                yield return null;
            }
        }
        else if (number == 4)
        {
            GetComponent<Animator>().Play("4", -1, 0.0f);
            Debug.Log("Drawing 4");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("4"))
            {
                yield return null;
            }
        }
        else if (number == 5)
        {
            GetComponent<Animator>().Play("5", -1, 0.0f);
            Debug.Log("Drawing 5");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("5"))
            {
                yield return null;
            }
        }
        else if (number == 6)
        {
            GetComponent<Animator>().Play("6", -1, 0.0f);
            Debug.Log("Drawing 6");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("6"))
            {
                yield return null;
            }
        }
        else if (number == 7)
        {
            GetComponent<Animator>().Play("7", -1, 0.0f);
            Debug.Log("Drawing 7");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("7"))
            {
                yield return null;
            }
        }
        else if (number == 8)
        {
            GetComponent<Animator>().Play("8", -1, 0.0f);
            Debug.Log("Drawing 8");
            if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("8"))
            {
                yield return null;
            }
        }
        else if (number == 9)
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
