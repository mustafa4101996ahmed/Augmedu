using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathQuizController : MonoBehaviour {

    private Animator anim;

    public void Idle()
    {
        GetComponent<Animator>().Play("idle", -1, 0.0f);
        //yield return new WaitForSeconds(4); // Character Speaks to user first
    }

    public void ScoreFour()
    {
        GetComponent<Animator>().SetTrigger("Score4");
        Debug.Log("Score: 4");
        //yield return new WaitForSeconds(4);
    }

    public void ScoreThree()
    {
        GetComponent<Animator>().SetTrigger("Score3");
        Debug.Log("Score: 3");
        //yield return new WaitForSeconds(4);
    }

    public void ScoreTwo()
    {
        GetComponent<Animator>().SetTrigger("Score2");
        Debug.Log("Score: 2");
        //yield return new WaitForSeconds(4);
    }

    public void ScoreOne()
    {
        GetComponent<Animator>().SetTrigger("Score1");
        Debug.Log("Score: 1");
        //yield return new WaitForSeconds(4);
    }

    public void ScoreZero()
    {
        GetComponent<Animator>().SetTrigger("Score0");
        Debug.Log("Score: 0");
        //yield return new WaitForSeconds(4);
    }

    void Update () 
	{
		
	}
}


