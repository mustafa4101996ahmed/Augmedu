using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathLearnScript : MonoBehaviour {

	[SerializeField]
		private Text number1_left = null;
	[SerializeField]
		private Text number1_right = null;
	[SerializeField]
		private Text number2_left = null;
	[SerializeField]
		private Text number2_right = null;
	[SerializeField]
		private Text result_left = null;
    [SerializeField]
        private Text result_mid = null;
    [SerializeField]
		private Text result_right = null;
	[SerializeField]
	    private Text carryText_right = null;

    public int rightAnswer, carryAnswer, midAnswer, leftAnswer;

    public Text rightResult, carryResult, midResult, leftResult;

    public int levelChoice = 1;

    public UImanager options;

    // Use this for initialization

    void Start()
    {
        NewQuestion();
    }

    public void NewQuestion ()
    {
        int NewScoreRight1, NewScoreRight2;
		int carry = 0;
		int NewScoreMid1, NewScoreMid2;
        int NewTotalLeft;

        if(levelChoice == 1)
        {
            SetLevel1();
        }
        else if (levelChoice == 2)
        {
            SetLevel2();
        }
        else if (levelChoice == 3)
        {
            SetLevel3();
        }

        rightResult.gameObject.SetActive(false);
        carryResult.gameObject.SetActive(false);
        midResult.gameObject.SetActive(false);
        leftResult.gameObject.SetActive(false);

        //right result
        int.TryParse(number1_right.text, out NewScoreRight1);
		int.TryParse(number2_right.text, out NewScoreRight2);

		int NewTotalRight = NewScoreRight1 + NewScoreRight2;
        if (NewTotalRight <= 9)
        {
            carry = 0;
            carryAnswer = 0;
            rightAnswer = NewTotalRight; //Store to check for answer later 
        }
        else
        {
            carry = 1;
            NewTotalRight = NewTotalRight - 10;
            rightAnswer = NewTotalRight; //Store to check for answer later 
            Debug.Log("Right Answer is: " + NewTotalRight);
        }

        //--------------
        if (carry == 1)
        {
            carryAnswer = 1; //Store to check for answer later 
            Debug.Log("Carry Answer is: " + carry);
        }

		//---------------------------------------------------------
		//mid result
		int.TryParse(number1_left.text, out NewScoreMid1);
		int.TryParse(number2_left.text, out NewScoreMid2);

		int NewTotalMid = NewScoreMid1 + NewScoreMid2 + carry;

        if (NewTotalMid <= 9) {
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
            midAnswer = NewTotalMid; //Store to check for answer later
            Debug.Log("Mid Answer is: " + NewTotalMid);
            leftAnswer = NewTotalLeft;
            Debug.Log("Left Answer is: " + NewTotalLeft);
        }

        result_left.text = leftAnswer.ToString();
        result_mid.text = midAnswer.ToString();
        result_right.text = rightAnswer.ToString();
        carryText_right.text = carryAnswer.ToString();

    }

    void Update()
    {
        
    }

    public void level1 ()
    {
        levelChoice = 1;
        options.optionsOpen1 = true;
        options.ToggleDropDownMenu1();
        NewQuestion();
    }

    public void level2()
    {
        levelChoice = 2;
        options.optionsOpen1 = true;
        options.ToggleDropDownMenu1();
        NewQuestion();
    }

    public void level3()
    {
        levelChoice = 3;
        options.optionsOpen1 = true;
        options.ToggleDropDownMenu1();
        NewQuestion();
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
