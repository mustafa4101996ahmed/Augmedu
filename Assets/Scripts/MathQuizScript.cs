using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathQuizScript : MonoBehaviour {

	[SerializeField]
		private Text number1_left = null;
	[SerializeField]
		private Text number1_right = null;
	[SerializeField]
		private Text number2_left = null;
	[SerializeField]
		private Text number2_right = null;

    public InputField inputLeft;
    public InputField inputMid;
    public InputField inputRight;
    public InputField inputCarry;

    public int rightAnswer, carryAnswer, midAnswer, leftAnswer;

    public int setDifficulty = 1;

    // Use this for initialization

    void Start()
    {
        NewQuestion();
    }

    public void NewQuestion ()
    {
        SetInitReferences();

        int NewScoreRight1, NewScoreRight2;
		int carry = 0;
		int NewScoreMid1, NewScoreMid2;
        int NewTotalLeft;

        if (setDifficulty == 1)
        {
            SetLevel1();
            Debug.Log("Level1");
        }
        else if (setDifficulty == 2)
        {
            SetLevel2();
            Debug.Log("Level2");
        }
        else if (setDifficulty == 3)
        {
            SetLevel3();
            Debug.Log("Level3");
        }


        //		result_right.text = number1_right.text + number2_right.text;

        //right result
        int.TryParse(number1_right.text, out NewScoreRight1);
		int.TryParse(number2_right.text, out NewScoreRight2);

		int NewTotalRight = NewScoreRight1 + NewScoreRight2;
        if (NewTotalRight <= 9)
        {
            //result_right.text = NewTotal.ToString();
            carry = 0;
            rightAnswer = NewTotalRight; //Store to check for answer later 
        }
        else
        {
            carry = 1;
            NewTotalRight = NewTotalRight - 10;
            //result_right.text = NewTotal.ToString();
            rightAnswer = NewTotalRight; //Store to check for answer later 
            Debug.Log("Right Answer is: " + NewTotalRight);
        }

        //--------------
        if (carry == 1)
        {
            //carryText_right.text = "1";
            carryAnswer = 1; //Store to check for answer later 
            Debug.Log("Carry Answer is: " + carry);
        }

		//---------------------------------------------------------
		//mid result
		int.TryParse(number1_left.text, out NewScoreMid1);
		int.TryParse(number2_left.text, out NewScoreMid2);

		int NewTotalMid = NewScoreMid1 + NewScoreMid2 + carry;

        if (NewTotalMid <= 9) {
			//result_mid.text = NewTotal.ToString ();
            midAnswer = NewTotalMid; //Store to check for answer later
            Debug.Log("Mid Answer is: " + NewTotalMid);
            NewTotalLeft = 0;
            leftAnswer = NewTotalLeft;
            Debug.Log("Left Answer is: " + NewTotalLeft);
        }
		else
		{
            NewTotalLeft = 1;
            NewTotalMid = NewTotalMid - 10;
			//result_mid.text = NewTotal_left.ToString ();
            midAnswer = NewTotalMid; //Store to check for answer later
            Debug.Log("Mid Answer is: " + NewTotalMid);
            leftAnswer = NewTotalLeft;
            Debug.Log("Left Answer is: " + NewTotalLeft);
        }

		//result_left.text = carry2.ToString ();

    }

    void SetInitReferences()
    {
        inputLeft.text = null;
        inputMid.text = null;
        inputRight.text = null;
        inputCarry.text = null; 
    }

    void SetLevel1() // 0 to 4
    {
        int rand1 = Random.Range(0, 4);
        number1_left.text = rand1.ToString();
        rand1 = Random.Range(0, 4);
        number1_right.text = rand1.ToString();
        rand1 = Random.Range(0, 4);
        number2_left.text = rand1.ToString();
        rand1 = Random.Range(0, 4);
        number2_right.text = rand1.ToString();
    }

    void SetLevel2() // 5 to 9
    {
        int rand1 = Random.Range(5, 9);
        number1_left.text = rand1.ToString();
        rand1 = Random.Range(5, 9);
        number1_right.text = rand1.ToString();
        rand1 = Random.Range(5, 9);
        number2_left.text = rand1.ToString();
        rand1 = Random.Range(5, 9);
        number2_right.text = rand1.ToString();
    }

    void SetLevel3() // 0 to 9
    {
        int rand1 = Random.Range(0, 9);
        number1_left.text = rand1.ToString();
        rand1 = Random.Range(0, 9);
        number1_right.text = rand1.ToString();
        rand1 = Random.Range(0, 9);
        number2_left.text = rand1.ToString();
        rand1 = Random.Range(0, 9);
        number2_right.text = rand1.ToString();
    }
}
